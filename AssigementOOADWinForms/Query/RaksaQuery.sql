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

CREATE PROCEDURE sp_UpsertInvoice
    @InvoiceID INT = NULL,
    @CustomerName VARCHAR(50),
    @CustomerPhone VARCHAR(50),
    @EmployeeID INT,
    @OrderDate DATETIME,
    @TotalAmount DECIMAL(18,2)
AS
BEGIN
    SET NOCOUNT ON;

    -- Check if InvoiceID exists
    IF EXISTS (SELECT 1 FROM tbInvoice WHERE InvoiceID = @InvoiceID)
    BEGIN
        -- Update existing record
        UPDATE tbInvoice
        SET
            CustomerName = @CustomerName,
            CustomerPhone = @CustomerPhone,
            EmployeeID = @EmployeeID,
            OrderDate = @OrderDate,
            TotalAmount = @TotalAmount
        WHERE InvoiceID = @InvoiceID;

        PRINT 'Invoice updated successfully.';
    END
    ELSE
    BEGIN
        -- Insert new record
        INSERT INTO tbInvoice (CustomerName, CustomerPhone, EmployeeID, OrderDate, TotalAmount)
        VALUES (@CustomerName, @CustomerPhone, @EmployeeID, @OrderDate, @TotalAmount);

        -- Optional: Return new InvoiceID
        SET @InvoiceID = SCOPE_IDENTITY();
        PRINT 'New invoice inserted successfully.';
    END
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


