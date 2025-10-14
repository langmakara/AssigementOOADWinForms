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
    @InvoiceID     INT = NULL OUTPUT,
    @CustomerName  VARCHAR(50),
    @CustomerPhone VARCHAR(50),
    @EmployeeID    INT,
    @OrderDate     DATETIME,
    @Status        VARCHAR(20) = 'Pending'
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @EmployeeName VARCHAR(150);
    SELECT @EmployeeName = EmployeeName FROM tbEmployee WHERE EmployeeID = @EmployeeID;

    IF @InvoiceID IS NOT NULL AND @InvoiceID <> 0 
       AND EXISTS (SELECT 1 FROM tbInvoice WHERE InvoiceID = @InvoiceID)
    BEGIN
        -- ✅ UPDATE EXISTING
        UPDATE tbInvoice
        SET CustomerName  = @CustomerName,
            CustomerPhone = @CustomerPhone,
            EmployeeID    = @EmployeeID,
            EmployeeName  = @EmployeeName,
            OrderDate     = @OrderDate,
            Status        = @Status
        WHERE InvoiceID = @InvoiceID;
    END
    ELSE
    BEGIN
        -- ✅ INSERT NEW
        INSERT INTO tbInvoice (CustomerName, CustomerPhone, EmployeeID, EmployeeName, OrderDate, TotalAmount, Status)
        VALUES (@CustomerName, @CustomerPhone, @EmployeeID, @EmployeeName, @OrderDate, 0, @Status);

        SET @InvoiceID = SCOPE_IDENTITY();
    END

    SELECT @InvoiceID AS InvoiceID;
END;
GO



-- =====================================
-- Delete Invoice
CREATE OR ALTER PROCEDURE sp_DeleteInvoice
    @InvoiceID INT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRANSACTION;

    IF EXISTS (SELECT 1 FROM tbInvoice WHERE InvoiceID = @InvoiceID)
    BEGIN
        DELETE FROM tbInvoiceDetail WHERE InvoiceID = @InvoiceID;
        DELETE FROM tbInvoice WHERE InvoiceID = @InvoiceID;

        COMMIT TRANSACTION;
        PRINT 'Invoice deleted successfully.';
    END
    ELSE
    BEGIN
        ROLLBACK TRANSACTION;
        PRINT 'Invoice not found.';
    END
END;
GO
-- =====================================
-- Start InvoiceDetail
-- =====================================
CREATE OR ALTER VIEW vwInvoiceDetail
AS
SELECT 
    InvoiceDetailID,
    InvoiceID,
    ProductID,
    ProductName,
    Quantity,
    UnitPrice,
    CAST(Quantity * UnitPrice AS DECIMAL(18,2)) AS TotalPrice
FROM tbInvoiceDetail;
GO
-- =====================================
-- Insert or update InvoiceDetail
-- =====================================
CREATE OR ALTER PROCEDURE spUpsertInvoiceDetail
    @InvoiceDetailID INT = NULL,
    @InvoiceID INT,
    @ProductID INT,
    @Quantity INT,
    @UnitPrice DECIMAL(18,2)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @ProductName VARCHAR(150);

    -- Lookup ProductName from tbProduct
    SELECT @ProductName = ProductName
    FROM tbProduct
    WHERE ProductID = @ProductID;

    -- Treat 0 or NULL as insert
    IF @InvoiceDetailID IS NULL OR @InvoiceDetailID = 0
    BEGIN
        INSERT INTO tbInvoiceDetail (InvoiceID, ProductID, ProductName, Quantity, UnitPrice)
        VALUES (@InvoiceID, @ProductID, @ProductName, @Quantity, @UnitPrice);

        SELECT SCOPE_IDENTITY() AS InvoiceDetailID;
    END
    ELSE
    BEGIN
        IF EXISTS (SELECT 1 FROM tbInvoiceDetail WHERE InvoiceDetailID = @InvoiceDetailID)
        BEGIN
            -- Update existing record
            UPDATE tbInvoiceDetail
            SET 
                InvoiceID = @InvoiceID,
                ProductID = @ProductID,
                ProductName = @ProductName,
                Quantity = @Quantity,
                UnitPrice = @UnitPrice
            WHERE InvoiceDetailID = @InvoiceDetailID;
        END
        ELSE
        BEGIN
            -- If ID does not exist, insert as new
            INSERT INTO tbInvoiceDetail (InvoiceID, ProductID, ProductName, Quantity, UnitPrice)
            VALUES (@InvoiceID, @ProductID, @ProductName, @Quantity, @UnitPrice);

            SELECT SCOPE_IDENTITY() AS InvoiceDetailID;
        END
    END
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

    -- Update invoices that still have details
    UPDATE tb
    SET tb.TotalAmount = ISNULL(d.Total, 0)
    FROM tbInvoice tb
    INNER JOIN (
        SELECT InvoiceID, SUM(Quantity * UnitPrice) AS Total
        FROM tbInvoiceDetail
        GROUP BY InvoiceID
    ) d ON tb.InvoiceID = d.InvoiceID
    WHERE tb.InvoiceID IN (SELECT InvoiceID FROM @AffectedInvoices);

    -- Set TotalAmount = 0 for invoices that have no details
    UPDATE tb
    SET tb.TotalAmount = 0
    FROM tbInvoice tb
    WHERE tb.InvoiceID IN (SELECT InvoiceID FROM @AffectedInvoices)
      AND NOT EXISTS (
          SELECT 1 FROM tbInvoiceDetail d
          WHERE d.InvoiceID = tb.InvoiceID
      );
END;
GO


