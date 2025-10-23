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
--Delete Product by Product Name
CREATE PROCEDURE sp_DeleteProductByName
    @ProductName NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM tbProduct WHERE ProductName = @ProductName)
    BEGIN
        DELETE FROM tbProduct
        WHERE ProductName = @ProductName;
        PRINT 'Product deleted successfully.';
    END
    ELSE
    BEGIN
        PRINT 'Product not found.';
    END
END;