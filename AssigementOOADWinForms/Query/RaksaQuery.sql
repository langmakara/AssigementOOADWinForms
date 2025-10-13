-- =====================================
-- Get all invoices
-- =====================================
CREATE OR ALTER PROCEDURE sp_GetAllInvoices
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        InvoiceID,
        CustomerName,
        CustomerPhone,
        EmployeeID,
        EmployeeName,  -- denormalized
        TotalAmount,
        OrderDate
    FROM tbInvoice
    ORDER BY OrderDate DESC;
END;
GO
--Insert or Update
CREATE OR ALTER PROCEDURE sp_InsertOrUpdateInvoice
    @InvoiceID INT = NULL OUTPUT,
    @CustomerName VARCHAR(50),
    @CustomerPhone VARCHAR(50),
    @EmployeeID INT,
    @OrderDate DATETIME
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @EmployeeName VARCHAR(150);

    -- Get Employee Name for denormalization
    SELECT @EmployeeName = EmployeeName 
    FROM tbEmployee
    WHERE EmployeeID = @EmployeeID;

    IF @InvoiceID IS NOT NULL AND EXISTS (SELECT 1 FROM tbInvoice WHERE InvoiceID = @InvoiceID)
    BEGIN
        -- Update existing invoice
        UPDATE tbInvoice
        SET CustomerName = @CustomerName,
            CustomerPhone = @CustomerPhone,
            EmployeeID = @EmployeeID,
            EmployeeName = @EmployeeName,
            OrderDate = @OrderDate
        WHERE InvoiceID = @InvoiceID;
    END
    ELSE
    BEGIN
        -- Insert new invoice
        INSERT INTO tbInvoice (CustomerName, CustomerPhone, EmployeeID, EmployeeName, OrderDate, TotalAmount)
        VALUES (@CustomerName, @CustomerPhone, @EmployeeID, @EmployeeName, @OrderDate, 0);

        SET @InvoiceID = SCOPE_IDENTITY();
    END

    -- Return the InvoiceID
    SELECT @InvoiceID AS InvoiceID;
END;
GO

-- =====================================
-- Delete Invoice
-- =====================================
CREATE OR ALTER PROCEDURE sp_DeleteInvoice
    @InvoiceID INT
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM tbInvoice WHERE InvoiceID = @InvoiceID)
    BEGIN
        DELETE FROM tbInvoiceDetail WHERE InvoiceID = @InvoiceID;
        DELETE FROM tbInvoice WHERE InvoiceID = @InvoiceID;
        PRINT 'Invoice deleted successfully.';
    END
    ELSE
    BEGIN
        PRINT 'Invoice not found.';
    END
END;
GO

-- =====================================
-- Insert Invoice Detail
-- =====================================
CREATE OR ALTER PROCEDURE sp_InsertInvoiceDetail
    @InvoiceID INT,
    @ProductID INT,
    @Quantity INT,
    @UnitPrice DECIMAL(18,2)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @ProductName VARCHAR(150);

    -- Get Product Name for denormalization
    SELECT @ProductName = ProductName 
    FROM tbProduct
    WHERE ProductID = @ProductID;

    INSERT INTO tbInvoiceDetail (InvoiceID, ProductID, ProductName, Quantity, UnitPrice)
    VALUES (@InvoiceID, @ProductID, @ProductName, @Quantity, @UnitPrice);
END;
GO

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
-- Trigger to update Invoice TotalAmount
-- =====================================
CREATE OR ALTER TRIGGER trg_UpdateInvoiceTotal
ON tbInvoiceDetail
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @AffectedInvoices TABLE (InvoiceID INT);

    INSERT INTO @AffectedInvoices (InvoiceID)
    SELECT DISTINCT InvoiceID FROM inserted
    UNION
    SELECT DISTINCT InvoiceID FROM deleted;

    UPDATE i
    SET TotalAmount = ISNULL(d.Total, 0)
    FROM tbInvoice i
    INNER JOIN (
        SELECT InvoiceID, SUM(Quantity * UnitPrice) AS Total
        FROM tbInvoiceDetail
        GROUP BY InvoiceID
    ) d ON i.InvoiceID = d.InvoiceID
    WHERE i.InvoiceID IN (SELECT InvoiceID FROM @AffectedInvoices);
END;
GO
