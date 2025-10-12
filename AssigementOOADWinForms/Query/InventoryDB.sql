-- =====================================
-- Users Table
-- =====================================
CREATE TABLE tbUser (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(50) UNIQUE NOT NULL,
    PasswordHash VARCHAR(255) NOT NULL,
    Role VARCHAR(50) NOT NULL CHECK (Role IN ('Admin', 'Manager', 'Staff')),
    CreatedAt DATETIME DEFAULT GETDATE()
);
GO

-- =====================================
-- Employees Table
-- =====================================
CREATE TABLE tbEmployee (
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeName VARCHAR(150) NOT NULL,
    Phone VARCHAR(50),
    Email VARCHAR(100),
    Address VARCHAR(255),
    Position VARCHAR(100),
    HireDate DATE DEFAULT GETDATE()
);
GO

-- =====================================
-- Supplier Table
-- =====================================
CREATE TABLE tbSupplier (
    SupplierID INT IDENTITY(1,1) PRIMARY KEY,
    SupplierName VARCHAR(150) NOT NULL,
    ContactName VARCHAR(100),
    Phone VARCHAR(50),
    Email VARCHAR(100),
    Address VARCHAR(255)
);
GO

-- =====================================
-- Product Table
-- =====================================
CREATE TABLE tbProduct (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName VARCHAR(150) NOT NULL,
    SupplierID INT,
    UnitPrice DECIMAL(18,2) NOT NULL,
    QuantityInStock INT DEFAULT 0,
    ReorderLevel INT DEFAULT 0,
    CreatedAt DATETIME DEFAULT GETDATE(),
    CONSTRAINT FK_Product_Supplier FOREIGN KEY (SupplierID)
        REFERENCES tbSupplier(SupplierID)
);
GO

-- =====================================
-- Purchase Order Table
-- =====================================
CREATE TABLE tbPurchaseOrder (
    PurchaseID INT IDENTITY(1,1) PRIMARY KEY,
    SupplierID INT,
    EmployeeID INT,
    OrderDate DATETIME DEFAULT GETDATE(),
    TotalAmount DECIMAL(18,2),
    CONSTRAINT FK_PurchaseOrder_Supplier FOREIGN KEY (SupplierID)
        REFERENCES tbSupplier(SupplierID),
    CONSTRAINT FK_PurchaseOrder_Employee FOREIGN KEY (EmployeeID)
        REFERENCES tbEmployee(EmployeeID)
);
GO

-- =====================================
-- Purchase Order Detail Table
-- =====================================
CREATE TABLE tbPurchaseOrderDetail (
    PurchaseDetailID INT IDENTITY(1,1) PRIMARY KEY,
    PurchaseID INT NOT NULL,
    ProductID INT NOT NULL,
    Quantity INT NOT NULL,
    UnitPrice DECIMAL(18,2) NOT NULL,
    CONSTRAINT FK_PurchaseDetail_Purchase FOREIGN KEY (PurchaseID)
        REFERENCES tbPurchaseOrder(PurchaseID),
    CONSTRAINT FK_PurchaseDetail_Product FOREIGN KEY (ProductID)
        REFERENCES tbProduct(ProductID)
);
GO

-- =====================================
-- Invoice (Sales Order) Table
-- =====================================
CREATE TABLE tbInvoice (
    InvoiceID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerName VARCHAR(50),
    CustomerPhone VARCHAR(50),
    EmployeeID INT,
    OrderDate DATETIME DEFAULT GETDATE(),
    TotalAmount DECIMAL(18,2),
    CONSTRAINT FK_Invoice_Employee FOREIGN KEY (EmployeeID)
        REFERENCES tbEmployee(EmployeeID)
);
GO

-- =====================================
-- Invoice Detail (Sales Order Detail) Table
-- =====================================
CREATE TABLE tbInvoicerDetail (
    InvoiceDetailID INT IDENTITY(1,1) PRIMARY KEY,
    InvoiceID INT NOT NULL,
    ProductID INT NOT NULL,
    Quantity INT NOT NULL,
    UnitPrice DECIMAL(18,2) NOT NULL,
    CONSTRAINT FK_InvoiceDetail_Invoice FOREIGN KEY (InvoiceID)
        REFERENCES tbInvoice(InvoiceID),
    CONSTRAINT FK_InvoiceDetail_Product FOREIGN KEY (ProductID)
        REFERENCES tbProduct(ProductID)
);
GO

-- =====================================
-- Inventory Transaction Table
-- =====================================
CREATE TABLE tbInventoryTransaction (
    TransactionID INT IDENTITY(1,1) PRIMARY KEY,
    ProductID INT NOT NULL,
    TransactionType VARCHAR(50) CHECK (TransactionType IN ('Purchase', 'Sale', 'Adjustment')),
    QuantityChange INT NOT NULL,
    TransactionDate DATETIME DEFAULT GETDATE(),
    ReferenceID INT,
    CONSTRAINT FK_InventoryTransaction_Product FOREIGN KEY (ProductID)
        REFERENCES tbProduct(ProductID)
);
GO

-- =====================================
-- Payment Table
-- =====================================
CREATE TABLE tbPayment (
    PaymentID INT IDENTITY(1,1) PRIMARY KEY,
    InvoiceID INT NOT NULL,
    PaymentDate DATETIME DEFAULT GETDATE(),
    PaymentMethod VARCHAR(50) CHECK (PaymentMethod IN ('Cash', 'Credit Card', 'Bank Transfer')),
    AmountPaid DECIMAL(18,2) NOT NULL,
    CONSTRAINT FK_Payment_Invoice FOREIGN KEY (InvoiceID)
        REFERENCES tbInvoice(InvoiceID)
);
GO

-- =====================================
-- Stock Adjustment Table
-- =====================================
CREATE TABLE tbStockAdjustment (
    AdjustmentID INT IDENTITY(1,1) PRIMARY KEY,
    ProductID INT NOT NULL,
    EmployeeID INT NOT NULL,
    AdjustmentType VARCHAR(50) CHECK (AdjustmentType IN ('Increase', 'Decrease')),
    Quantity INT NOT NULL,
    Reason VARCHAR(255),
    AdjustmentDate DATETIME DEFAULT GETDATE(),
    CONSTRAINT FK_StockAdjustment_Product FOREIGN KEY (ProductID)
        REFERENCES tbProduct(ProductID),
    CONSTRAINT FK_StockAdjustment_Employee FOREIGN KEY (EmployeeID)
        REFERENCES tbEmployee(EmployeeID)
);
GO

-- =====================================
-- (OPTIONAL) Note: The last line in your definition:
-- Ref: "tbEmployee"."Phone" < "tbUser"."CreatedAt"
-- This is not a valid SQL relationship.
-- If you meant to add a constraint, please clarify what logic you need.
-- =====================================
