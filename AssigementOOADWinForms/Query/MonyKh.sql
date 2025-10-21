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
