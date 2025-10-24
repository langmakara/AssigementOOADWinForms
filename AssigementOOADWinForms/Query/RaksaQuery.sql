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
        CustomerAddress,
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
    @CustomerAddress VARCHAR(225),
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
            CustomerAddress = @CustomerAddress,
            EmployeeID    = @EmployeeID,
            EmployeeName  = @EmployeeName,
            OrderDate     = @OrderDate,
            Status        = @Status
        WHERE InvoiceID = @InvoiceID;
    END
    ELSE
    BEGIN
        -- ✅ INSERT NEW
        INSERT INTO tbInvoice (CustomerName, CustomerPhone,CustomerAddress, EmployeeID, EmployeeName, OrderDate, TotalAmount, Status)
        VALUES (@CustomerName, @CustomerPhone,@CustomerAddress, @EmployeeID, @EmployeeName, @OrderDate, 0, @Status);

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
    DECLARE @ResultID INT;

    SELECT @ProductName = ProductName
    FROM tbProduct
    WHERE ProductID = @ProductID;

    IF @InvoiceDetailID IS NULL OR @InvoiceDetailID = 0
    BEGIN
        INSERT INTO tbInvoiceDetail (InvoiceID, ProductID, ProductName, Quantity, UnitPrice)
        VALUES (@InvoiceID, @ProductID, @ProductName, @Quantity, @UnitPrice);

        SET @ResultID = CAST(SCOPE_IDENTITY() AS INT);
    END
    ELSE
    BEGIN
        UPDATE tbInvoiceDetail
        SET InvoiceID = @InvoiceID,
            ProductID = @ProductID,
            ProductName = @ProductName,
            Quantity = @Quantity,
            UnitPrice = @UnitPrice
        WHERE InvoiceDetailID = @InvoiceDetailID;

        SET @ResultID = @InvoiceDetailID;
    END

    -- Always return exactly one row
    SELECT @ResultID AS InvoiceDetailID;
END
GO
--====================================================================================
CREATE OR ALTER PROCEDURE sp_DeleteInvoiceDetail
    @InvoiceDetailID INT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRANSACTION;

    IF EXISTS (SELECT 1 FROM tbInvoiceDetail WHERE InvoiceDetailID = @InvoiceDetailID)
    BEGIN
        DELETE FROM tbInvoiceDetail
        WHERE InvoiceDetailID = @InvoiceDetailID;

        COMMIT TRANSACTION;
        PRINT 'Invoice detail deleted successfully.';
    END
    ELSE
    BEGIN
        ROLLBACK TRANSACTION;
        PRINT 'Invoice detail not found.';
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

    -- Update invoices with existing details
    UPDATE tb
    SET tb.TotalAmount = d.Total
    FROM tbInvoice tb
    INNER JOIN (
        SELECT InvoiceID, SUM(Quantity * UnitPrice) AS Total
        FROM tbInvoiceDetail
        GROUP BY InvoiceID
    ) d ON tb.InvoiceID = d.InvoiceID
    WHERE tb.InvoiceID IN (SELECT InvoiceID FROM @AffectedInvoices);

    -- Only update to 0 if the invoice truly has no details
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
---=======================================================================
CREATE OR ALTER TRIGGER trg_UpdateStockOnDelivery
ON tbInvoice
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Only process invoices where status changed to Delivered
    INSERT INTO tbInventoryTransaction (ProductID, ProductName, ProductUnitPrice, TransactionType, QuantityChange, TransactionDate, ReferenceID)
    SELECT d.ProductID, d.ProductName, d.UnitPrice, 'Sale', -d.Quantity, GETDATE(), d.InvoiceID
    FROM tbInvoiceDetail d
    INNER JOIN inserted i ON d.InvoiceID = i.InvoiceID
    INNER JOIN deleted oldI ON oldI.InvoiceID = i.InvoiceID
    WHERE i.Status = 'Delivered' AND oldI.Status <> 'Delivered';
END;
GO
--===============================================================================
CREATE OR ALTER TRIGGER trg_InvoiceDetail_Inventory
ON tbInvoiceDetail
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    -- Only handle inventory if invoice is already delivered
    INSERT INTO tbInventoryTransaction (ProductID, ProductName, ProductUnitPrice, TransactionType, QuantityChange, TransactionDate, ReferenceID)
    SELECT 
        i.ProductID,
        i.ProductName,
        i.UnitPrice,
        'Sale',
        -i.Quantity,
        GETDATE(),
        i.InvoiceID
    FROM inserted i
    INNER JOIN tbInvoice inv ON i.InvoiceID = inv.InvoiceID
    WHERE inv.Status = 'Delivered';

    -- For deleted invoice details, restore stock only if invoice was delivered
    INSERT INTO tbInventoryTransaction (ProductID, ProductName, ProductUnitPrice, TransactionType, QuantityChange, TransactionDate, ReferenceID)
    SELECT 
        d.ProductID,
        d.ProductName,
        d.UnitPrice,
        'Adjustment',
        d.Quantity,
        GETDATE(),
        d.InvoiceID
    FROM deleted d
    INNER JOIN tbInvoice inv ON d.InvoiceID = inv.InvoiceID
    WHERE inv.Status = 'Delivered';
END;
GO

GO
---=======================================================================

CREATE OR ALTER TRIGGER trg_PurchaseOrderDetail_Inventory
ON tbPurchaseOrderDetail
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    -- Insert InventoryTransaction for new purchase
    INSERT INTO tbInventoryTransaction (ProductID, ProductName, ProductUnitPrice, TransactionType, QuantityChange, TransactionDate, ReferenceID)
    SELECT 
        i.ProductID,
        i.ProductName,
        i.UnitPrice,
        'Purchase',
        i.Quantity,          -- Stock increases
        GETDATE(),
        i.PurchaseID
    FROM inserted i;

    -- For deleted purchase details, reduce stock
    INSERT INTO tbInventoryTransaction (ProductID, ProductName, ProductUnitPrice, TransactionType, QuantityChange, TransactionDate, ReferenceID)
    SELECT 
        d.ProductID,
        d.ProductName,
        d.UnitPrice,
        'Adjustment',         -- Adjustment because purchase deleted
        -d.Quantity,          -- Stock decreases
        GETDATE(),
        d.PurchaseID
    FROM deleted d;
END;
GO
---=======================================================================
CREATE OR ALTER TRIGGER trg_StockAdjustment_Inventory
ON tbStockAdjustment
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    -- Insert transaction for adjustment
    INSERT INTO tbInventoryTransaction (ProductID, ProductName, ProductUnitPrice, TransactionType, QuantityChange, TransactionDate, ReferenceID)
    SELECT 
        i.ProductID,
        i.ProductName,
        0,                          -- UnitPrice not needed
        'Adjustment',
        CASE WHEN i.AdjustmentType = 'Increase' THEN i.Quantity ELSE -i.Quantity END,
        GETDATE(),
        i.AdjustmentID
    FROM inserted i;

    -- For deleted adjustment, revert stock
    INSERT INTO tbInventoryTransaction (ProductID, ProductName, ProductUnitPrice, TransactionType, QuantityChange, TransactionDate, ReferenceID)
    SELECT 
        d.ProductID,
        d.ProductName,
        0,
        'Adjustment',
        CASE WHEN d.AdjustmentType = 'Increase' THEN -d.Quantity ELSE d.Quantity END,
        GETDATE(),
        d.AdjustmentID
    FROM deleted d;
END;
GO
---=============================Handle Trigger transaction-=====================================
CREATE OR ALTER TRIGGER trg_InventoryStock_ReturnTransfer
ON tbInventoryTransaction
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        -- ============================
        -- Handle INSERT / UPDATE for ReturnIn, ReturnOut, Transfer
        -- ============================
        UPDATE p
        SET p.QuantityInStock = p.QuantityInStock
            + CASE 
                WHEN i.TransactionType = 'ReturnIn' THEN i.QuantityChange
                WHEN i.TransactionType = 'ReturnOut' THEN -i.QuantityChange
                WHEN i.TransactionType = 'Transfer' THEN i.QuantityChange
                ELSE 0
              END
        FROM tbProduct p
        INNER JOIN inserted i 
            ON p.ProductID = i.ProductID
        WHERE i.TransactionType IN ('ReturnIn','ReturnOut','Transfer');

        -- ============================
        -- Handle DELETE (revert effect)
        -- ============================
        UPDATE p
        SET p.QuantityInStock = p.QuantityInStock
            - CASE 
                WHEN d.TransactionType = 'ReturnIn' THEN d.QuantityChange
                WHEN d.TransactionType = 'ReturnOut' THEN -d.QuantityChange
                WHEN d.TransactionType = 'Transfer' THEN d.QuantityChange
                ELSE 0
              END
        FROM tbProduct p
        INNER JOIN deleted d 
            ON p.ProductID = d.ProductID
        WHERE d.TransactionType IN ('ReturnIn','ReturnOut','Transfer');

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        DECLARE @ErrorMessage NVARCHAR(4000), @ErrorSeverity INT, @ErrorState INT;
        SELECT 
            @ErrorMessage = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE();
        RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END;
GO

---=======================================================================
-- =====================================
-- Stored Procedure: Insert or Update InventoryTransaction
-- =====================================
CREATE OR ALTER PROCEDURE sp_InsertOrUpdateInventoryTransaction
    @TransactionID INT = 0,               -- Pass 0 for new record
    @ProductID INT,
    @TransactionType VARCHAR(50),
    @QuantityChange INT,
    @TransactionDate DATETIME = NULL      -- Optional, defaults to GETDATE()
AS
BEGIN
    SET NOCOUNT ON;

    -- Default transaction date
    IF @TransactionDate IS NULL
        SET @TransactionDate = GETDATE();

    DECLARE @ProductName VARCHAR(150);
    DECLARE @ProductUnitPrice DECIMAL(18,2);

    -- 🔹 Get product info based on ProductID
    SELECT 
        @ProductName = ProductName,
        @ProductUnitPrice = UnitPrice
    FROM tbProduct
    WHERE ProductID = @ProductID;

    -- 🔹 Update if TransactionID exists
    IF EXISTS (SELECT 1 FROM tbInventoryTransaction WHERE TransactionID = @TransactionID AND @TransactionID <> 0)
    BEGIN
        UPDATE tbInventoryTransaction
        SET 
            ProductID = @ProductID,
            ProductName = @ProductName,
            ProductUnitPrice = @ProductUnitPrice,
            TransactionType = @TransactionType,
            QuantityChange = @QuantityChange,
            TransactionDate = @TransactionDate
        WHERE TransactionID = @TransactionID;
    END
    ELSE
    BEGIN
        -- 🔹 Insert new transaction
        INSERT INTO tbInventoryTransaction
            (ProductID, ProductName, ProductUnitPrice, TransactionType, QuantityChange, TransactionDate)
        VALUES
            (@ProductID, @ProductName, @ProductUnitPrice, @TransactionType, @QuantityChange, @TransactionDate);
    END
END;
GO


--=========================================================================================
CREATE OR ALTER PROCEDURE sp_GetAllInventoryTransactions
AS
BEGIN
    SELECT TransactionID, ProductID, ProductName, ProductUnitPrice, TransactionType, QuantityChange, TransactionDate
    FROM tbInventoryTransaction;
END
GO

--====================================Run =====================================================================
ALTER TABLE tbInventoryTransaction
DROP CONSTRAINT CK_tbInventoryTransaction_TransactionType;
ALTER TABLE tbInventoryTransaction
ADD CONSTRAINT CK_tbInventoryTransaction_TransactionType
CHECK (TransactionType IN ('Purchase','Sale','Adjustment','ReturnIn','ReturnOut','Transfer'));
