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
