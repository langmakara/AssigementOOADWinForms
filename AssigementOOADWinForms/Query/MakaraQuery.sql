-- =====================================
-- Get all users
-- =====================================
CREATE OR ALTER PROCEDURE sp_GetAllUsers
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        UserID,
        Username,
        PasswordHash,
        Role,
        CreatedAt
    FROM dbo.Users
    ORDER BY CreatedAt DESC;
END;
GO


-- =====================================
-- Insert or Update User
-- =====================================
CREATE OR ALTER PROCEDURE sp_InsertOrUpdateUser
    @UserID        INT = NULL OUTPUT,
    @Username      VARCHAR(100),
    @PasswordHash  VARCHAR(255),
    @Role          VARCHAR(50),
    @CreatedAt     DATETIME = NULL
AS
BEGIN
    SET NOCOUNT ON;

    -- Set default CreatedAt if null (for new insert)
    IF @CreatedAt IS NULL
        SET @CreatedAt = GETDATE();

    -- If updating existing record
    IF @UserID IS NOT NULL AND EXISTS (SELECT 1 FROM dbo.Users WHERE UserID = @UserID)
    BEGIN
        UPDATE dbo.Users
        SET 
            Username = @Username,
            PasswordHash = @PasswordHash,
            Role = @Role
        WHERE UserID = @UserID;
    END
    ELSE
    BEGIN
        INSERT INTO dbo.Users (Username, PasswordHash, Role, CreatedAt)
        VALUES (@Username, @PasswordHash, @Role, @CreatedAt);

        SET @UserID = SCOPE_IDENTITY();
    END

    SELECT @UserID AS UserID;
END;
GO


-- =====================================
-- Delete User
-- =====================================
CREATE OR ALTER PROCEDURE sp_DeleteUser
    @UserID INT
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM dbo.Users WHERE UserID = @UserID)
    BEGIN
        DELETE FROM dbo.Users WHERE UserID = @UserID;
        PRINT 'User deleted successfully.';
    END
    ELSE
    BEGIN
        PRINT 'User not found.';
    END
END;
GO


-- =====================================
-- Get User by ID
-- =====================================
CREATE OR ALTER PROCEDURE sp_GetUserById
    @UserID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        UserID,
        Username,
        PasswordHash,
        Role,
        CreatedAt
    FROM dbo.Users
    WHERE UserID = @UserID;
END;
GO

USE InventoryDB;
GO
-- =====================================

-- =====================================
-- Get all employees
-- =====================================
CREATE OR ALTER PROCEDURE sp_GetAllEmployees
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        EmployeeID,
        EmployeeName,
        Phone,
        Email,
        Address,
        Position,
        HireDate
    FROM tbEmployee
    ORDER BY EmployeeName;
END;
GO


-- =====================================
-- Insert or Update Employee
-- =====================================
CREATE OR ALTER PROCEDURE sp_InsertOrUpdateEmployee
    @EmployeeID INT = NULL OUTPUT,
    @EmployeeName NVARCHAR(100),
    @Phone NVARCHAR(50),
    @Email NVARCHAR(100),
    @Address NVARCHAR(200),
    @Position NVARCHAR(100),
    @HireDate DATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Validation for required fields
    IF @EmployeeName IS NULL OR LTRIM(RTRIM(@EmployeeName)) = ''
       OR @Phone IS NULL OR LTRIM(RTRIM(@Phone)) = ''
       OR @Position IS NULL OR LTRIM(RTRIM(@Position)) = ''
    BEGIN
        RAISERROR('EmployeeName, Phone, and Position are required.', 16, 1);
        RETURN;
    END

    -- If EmployeeID exists → UPDATE
    IF @EmployeeID IS NOT NULL AND EXISTS (SELECT 1 FROM tbEmployee WHERE EmployeeID = @EmployeeID)
    BEGIN
        UPDATE tbEmployee
        SET 
            EmployeeName = @EmployeeName,
            Phone = @Phone,
            Email = @Email,
            Address = @Address,
            Position = @Position,
            HireDate = @HireDate
        WHERE EmployeeID = @EmployeeID;
    END
    ELSE
    BEGIN
        INSERT INTO tbEmployee (EmployeeName, Phone, Email, Address, Position, HireDate)
        VALUES (@EmployeeName, @Phone, @Email, @Address, @Position, @HireDate);

        SET @EmployeeID = SCOPE_IDENTITY();
    END

    -- Return the current EmployeeID
    SELECT @EmployeeID AS EmployeeID;
END;
GO


-- =====================================
-- Delete Employee
-- =====================================
CREATE OR ALTER PROCEDURE sp_DeleteEmployee
    @EmployeeID INT
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM tbEmployee WHERE EmployeeID = @EmployeeID)
    BEGIN
        DELETE FROM tbEmployee
        WHERE EmployeeID = @EmployeeID;

        PRINT 'Employee deleted successfully.';
    END
    ELSE
    BEGIN
        PRINT 'Employee not found.';
    END
END;
GO
-- =====================================

-- =====================================
-- Get All Purchase Orders
-- =====================================
CREATE OR ALTER PROCEDURE sp_GetAllPurchaseOrders
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        PurchaseID,
        SupplierID,
        SupplierName,
        EmployeeID,
        EmployeeName,
        OrderDate,
        TotalAmount
    FROM dbo.tbPurchaseOrder
    ORDER BY OrderDate DESC;
END;
GO


-- =====================================
-- Insert or Update Purchase Order
-- =====================================
CREATE OR ALTER PROCEDURE sp_InsertOrUpdatePurchaseOrder
    @PurchaseID     INT = NULL OUTPUT,
    @SupplierID     INT,
    --@SupplierName   NVARCHAR(100),
    @EmployeeID     INT,
    --@EmployeeName   NVARCHAR(100),
    @OrderDate      DATETIME = NULL,
    @TotalAmount    DECIMAL(18,2)
AS
BEGIN
    SET NOCOUNT ON;
	DECLARE @EmployeeName NVARCHAR(100);
    SELECT @EmployeeName = EmployeeName FROM dbo.tbEmployee WHERE EmployeeID = @EmployeeID;
	DECLARE @SupplierName   NVARCHAR(100);
	SELECT @SupplierName = SupplierName FROM dbo.tbSupplier WHERE SupplierID = @SupplierID;
    IF @OrderDate IS NULL
        SET @OrderDate = GETDATE();

    -- Update existing record
    IF @PurchaseID IS NOT NULL AND EXISTS (SELECT 1 FROM dbo.tbPurchaseOrder WHERE PurchaseID = @PurchaseID)
    BEGIN
        UPDATE dbo.tbPurchaseOrder
        SET 
            SupplierID = @SupplierID,
            SupplierName = @SupplierName,
            EmployeeID = @EmployeeID,
            EmployeeName = @EmployeeName,
            OrderDate = @OrderDate,
            TotalAmount = @TotalAmount
        WHERE PurchaseID = @PurchaseID;
    END
    ELSE
    BEGIN
        INSERT INTO dbo.tbPurchaseOrder 
        (
            SupplierID,
            SupplierName,
            EmployeeID,
            EmployeeName,
            OrderDate,
            TotalAmount
        )
        VALUES 
        (
            @SupplierID,
            @SupplierName,
            @EmployeeID,
            @EmployeeName,
            @OrderDate,
            @TotalAmount
        );

        SET @PurchaseID = SCOPE_IDENTITY();
    END

    SELECT @PurchaseID AS PurchaseID;
END;
GO


-- =====================================
-- Delete Purchase Order
-- =====================================
CREATE OR ALTER PROCEDURE sp_DeletePurchaseOrder
    @PurchaseID INT
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM dbo.tbPurchaseOrder WHERE PurchaseID = @PurchaseID)
    BEGIN
        DELETE FROM dbo.tbPurchaseOrder WHERE PurchaseID = @PurchaseID;
        PRINT 'Purchase order deleted successfully.';
    END
    ELSE
    BEGIN
        PRINT 'Purchase order not found.';
    END
END;
GO


-- =====================================
-- Get Purchase Order by ID
-- =====================================
CREATE OR ALTER PROCEDURE sp_GetPurchaseOrderById
    @PurchaseID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        PurchaseID,
        SupplierID,
        SupplierName,
        EmployeeID,
        EmployeeName,
        OrderDate,
        TotalAmount
    FROM dbo.tbPurchaseOrder
    WHERE PurchaseID = @PurchaseID;
END;
GO



