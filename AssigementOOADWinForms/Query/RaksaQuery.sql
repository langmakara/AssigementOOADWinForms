CREATE PROCEDURE sp_GetAllInvoices
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        i.InvoiceID,
        i.CustomerName,
        i.CustomerPhone,
        e.EmployeeID,
        e.EmployeeName,
        i.TotalAmount,
        i.OrderDate
    FROM tbInvoice AS i
    INNER JOIN tbEmployee AS e
        ON i.EmployeeID = e.EmployeeID
    ORDER BY i.OrderDate DESC;
END;
GO
--Isert Or Update
CREATE OR ALTER PROCEDURE sp_InsertInvoice
    @InvoiceID INT OUTPUT,
    @CustomerName VARCHAR(50),
    @CustomerPhone VARCHAR(50),
    @EmployeeID INT,
    @OrderDate DATETIME
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO tbInvoice (CustomerName, CustomerPhone, EmployeeID, OrderDate, TotalAmount)
    VALUES (@CustomerName, @CustomerPhone, @EmployeeID, @OrderDate, 0); -- insert 0 first

    SET @InvoiceID = SCOPE_IDENTITY();

    SELECT @InvoiceID AS InvoiceID;
END;
GO
--Trigger automatic update invoice
CREATE TRIGGER trg_UpdateInvoiceTotal
ON tbInvoiceDetail
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @InvoiceID INT;
    SELECT @InvoiceID = InvoiceID FROM inserted;

    UPDATE tbInvoice
    SET TotalAmount = (
        SELECT SUM(Quantity * UnitPrice)
        FROM tbInvoiceDetail
        WHERE InvoiceID = @InvoiceID
    )
    WHERE InvoiceID = @InvoiceID;
END;
GO
--Remove Store Procedure 
CREATE PROCEDURE sp_DeleteInvoice
    @InvoiceID INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Check if the invoice exists
    IF EXISTS (SELECT 1 FROM tbInvoice WHERE InvoiceID = @InvoiceID)
    BEGIN
        -- Optional: Delete related details first to maintain foreign key integrity
        DELETE FROM tbInvoicerDetail WHERE InvoiceID = @InvoiceID;

        -- Then delete the invoice itself
        DELETE FROM tbInvoice WHERE InvoiceID = @InvoiceID;

        PRINT 'Invoice deleted successfully.';
    END
    ELSE
    BEGIN
        PRINT 'Invoice not found.';
    END
END;
GO
--Insert Invoice Detail
CREATE OR ALTER PROCEDURE sp_InsertInvoiceDetail
    @InvoiceID INT,
    @ProductID INT,
    @Quantity INT,
    @UnitPrice DECIMAL(18,2)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO tbInvoiceDetail (InvoiceID, ProductID, Quantity, UnitPrice)
    VALUES (@InvoiceID, @ProductID, @Quantity, @UnitPrice);
END;
GO

--Employee Table Select 
CREATE PROCEDURE sp_GetAllEmployees
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


