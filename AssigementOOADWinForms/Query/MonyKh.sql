--StoreProcedure to Insert or Update Supplier information
CREATE PROCEDURE sp_InsertOrUpdate_Supplier
    @SupplierID INT = NULL,           -- If NULL → Insert, else → Update
    @SupplierName VARCHAR(150),
    @ContactName VARCHAR(100) = NULL,
    @Phone VARCHAR(50) = NULL,
    @Email VARCHAR(100) = NULL,
    @Address VARCHAR(255) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    IF @SupplierID IS NULL OR @SupplierID = 0
    BEGIN
        -- INSERT new supplier
        INSERT INTO tbSupplier (SupplierName, ContactName, Phone, Email, Address)
        VALUES (@SupplierName, @ContactName, @Phone, @Email, @Address);

        PRINT 'New supplier inserted successfully.';
    END
    ELSE
    BEGIN
        -- UPDATE existing supplier
        UPDATE tbSupplier
        SET SupplierName = @SupplierName,
            ContactName = @ContactName,
            Phone = @Phone,
            Email = @Email,
            Address = @Address
        WHERE SupplierID = @SupplierID;

        PRINT 'Supplier updated successfully.';
    END
END;
GO
--StoreProcedure to Insert or Update Product information
CREATE PROCEDURE sp_InsertOrUpdateProduct
    @ProductID INT=Null,
    @ProductName NVARCHAR(100),
    @SupplierID INT=Null,
    @SupplierName NVARCHAR(100),
    @UnitPrice DECIMAL(18,2),
    @QuantityInStock INT
AS
BEGIN
    SET NOCOUNT ON;
    -- Check if product already exists
     IF @ProductID IS NOT NULL AND EXISTS (SELECT 1 FROM tbProduct WHERE ProductID = @ProductID)
    BEGIN
        UPDATE tbProduct
        SET 
            ProductName = @ProductName,
            SupplierID = @SupplierID,
            SupplierName = @SupplierName,
            UnitPrice = @UnitPrice,
            QuantityInStock = @QuantityInStock
        WHERE ProductID = @ProductID;
    END
    ELSE
    BEGIN
        -- If not exists → INSERT
        INSERT INTO tbProduct (ProductName, SupplierID, SupplierName, UnitPrice, QuantityInStock)
        VALUES (@ProductName, @SupplierID, @SupplierName, @UnitPrice, @QuantityInStock);
    END
END;
--StoreProcedure to Insert or Update Payment information
CREATE PROCEDURE sp_InsertOrUpdatePayment
    @PaymentID INT = NULL,
    @InvoiceID INT,
    @PaymentDate DATETIME = NULL,
    @PaymentMethod VARCHAR(50),
    @AmountPaid DECIMAL(18,2)
AS
BEGIN
    SET NOCOUNT ON;

    -- If PaymentDate not provided, use current date/time
    IF @PaymentDate IS NULL
        SET @PaymentDate = GETDATE();

    -- Check if record exists
    IF EXISTS (SELECT 1 FROM tbPayment WHERE PaymentID = @PaymentID AND InvoiceID = @InvoiceID)
    BEGIN
        -- ✅ Update existing record
        UPDATE tbPayment
        SET
            PaymentDate = @PaymentDate,
            PaymentMethod = @PaymentMethod,
            AmountPaid = @AmountPaid
        WHERE PaymentID = @PaymentID AND InvoiceID = @InvoiceID;

        PRINT 'Payment record updated successfully.';
    END
    ELSE
    BEGIN
        -- ✅ Insert new record
        INSERT INTO tbPayment (InvoiceID, PaymentDate, PaymentMethod, AmountPaid)
        VALUES (@InvoiceID, @PaymentDate, @PaymentMethod, @AmountPaid);

        PRINT 'New payment record inserted successfully.';
    END
END;
