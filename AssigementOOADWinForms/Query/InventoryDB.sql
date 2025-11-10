---- =====================================
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
-- Product Table (denormalized)
-- =====================================
CREATE TABLE tbProduct (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName VARCHAR(150) NOT NULL,
    SupplierID INT,
    SupplierName VARCHAR(150),
    SupplierPhone VARCHAR(50),
    UnitPrice DECIMAL(18,2) NOT NULL,
    QuantityInStock INT DEFAULT 0,
    CreatedAt DATETIME DEFAULT GETDATE(),
    CONSTRAINT FK_tbProduct_tbSupplier FOREIGN KEY (SupplierID) REFERENCES tbSupplier(SupplierID)
);
GO

-- =====================================
-- Purchase Order Table (denormalized)
-- =====================================
CREATE TABLE tbPurchaseOrder (
    PurchaseID INT IDENTITY(1,1) PRIMARY KEY,
    SupplierID INT,
    SupplierName VARCHAR(150),
    EmployeeID INT,
    EmployeeName VARCHAR(150),
    OrderDate DATETIME DEFAULT GETDATE(),
    TotalAmount DECIMAL(18,2),
    CONSTRAINT FK_tbPurchaseOrder_tbSupplier FOREIGN KEY (SupplierID) REFERENCES tbSupplier(SupplierID),
    CONSTRAINT FK_tbPurchaseOrder_tbEmployee FOREIGN KEY (EmployeeID) REFERENCES tbEmployee(EmployeeID)
);
GO

-- =====================================
-- Purchase Order Detail Table (denormalized)
-- =====================================
CREATE TABLE tbPurchaseOrderDetail (
    PurchaseDetailID INT IDENTITY(1,1) PRIMARY KEY,
    PurchaseID INT NOT NULL,
    ProductID INT NOT NULL,
    ProductName VARCHAR(150),
    Quantity INT NOT NULL,
    UnitPrice DECIMAL(18,2) NOT NULL,
    CONSTRAINT FK_tbPurchaseOrderDetail_tbPurchaseOrder FOREIGN KEY (PurchaseID) REFERENCES tbPurchaseOrder(PurchaseID),
    CONSTRAINT FK_tbPurchaseOrderDetail_tbProduct FOREIGN KEY (ProductID) REFERENCES tbProduct(ProductID)
);
GO

-- =====================================
-- Invoice Table (denormalized)
-- =====================================
CREATE TABLE tbInvoice (
    InvoiceID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerName VARCHAR(50),
    CustomerPhone VARCHAR(50),
    CustomerAddress VARCHAR(255),
    EmployeeID INT,
    EmployeeName VARCHAR(150),
    OrderDate DATETIME DEFAULT GETDATE(),
    Status VARCHAR(50) NOT NULL DEFAULT 'Pending',
    TotalAmount DECIMAL(18,2),
    CONSTRAINT FK_tbInvoice_tbEmployee FOREIGN KEY (EmployeeID) REFERENCES tbEmployee(EmployeeID)
);
GO

-- =====================================
-- Invoice Detail Table (denormalized)
-- =====================================
CREATE TABLE tbInvoiceDetail (
    InvoiceDetailID INT IDENTITY(1,1) PRIMARY KEY,
    InvoiceID INT NOT NULL,
    ProductID INT NOT NULL,
    ProductName VARCHAR(150),
    Quantity INT NOT NULL,
    UnitPrice DECIMAL(18,2) NOT NULL,
    CONSTRAINT FK_tbInvoiceDetail_tbInvoice FOREIGN KEY (InvoiceID) REFERENCES tbInvoice(InvoiceID),
    CONSTRAINT FK_tbInvoiceDetail_tbProduct FOREIGN KEY (ProductID) REFERENCES tbProduct(ProductID)
);
GO

-- =====================================
-- Inventory Transaction Table (denormalized)
-- =====================================
CREATE TABLE tbInventoryTransaction (
    TransactionID INT IDENTITY(1,1) PRIMARY KEY,
    ProductID INT NOT NULL,
    ProductName VARCHAR(150),
    ProductUnitPrice DECIMAL(18,2),
    TransactionType VARCHAR(50) CHECK (TransactionType IN ('Purchase', 'Sale', 'Adjustment')),
    QuantityChange INT NOT NULL,
    TransactionDate DATETIME DEFAULT GETDATE(),
    ReferenceID INT,
    CONSTRAINT FK_tbInventoryTransaction_tbProduct FOREIGN KEY (ProductID) REFERENCES tbProduct(ProductID)
);
GO

-- =====================================
-- Payment Table (denormalized)
-- =====================================
CREATE TABLE tbPayment (
    PaymentID INT IDENTITY(1,1) PRIMARY KEY,
    InvoiceID INT NOT NULL,
    CustomerName VARCHAR(50),
    InvoiceTotalAmount DECIMAL(18,2),
    PaymentDate DATETIME DEFAULT GETDATE(),
    PaymentMethod VARCHAR(50) CHECK (PaymentMethod IN ('Cash', 'Credit Card', 'Bank Transfer')),
    AmountPaid DECIMAL(18,2) NOT NULL,
    CONSTRAINT FK_tbPayment_tbInvoice FOREIGN KEY (InvoiceID) REFERENCES tbInvoice(InvoiceID)
);
GO

-- =====================================
-- Stock Adjustment Table (denormalized)
-- =====================================
CREATE TABLE tbStockAdjustment (
    AdjustmentID INT IDENTITY(1,1) PRIMARY KEY,
    ProductID INT NOT NULL,
    ProductName VARCHAR(150),
    EmployeeID INT NOT NULL,
    EmployeeName VARCHAR(150),
    AdjustmentType VARCHAR(50) CHECK (AdjustmentType IN ('Increase', 'Decrease')),
    Quantity INT NOT NULL,
    Reason VARCHAR(255),
    AdjustmentDate DATETIME DEFAULT GETDATE(),
    CONSTRAINT FK_tbStockAdjustment_tbProduct FOREIGN KEY (ProductID) REFERENCES tbProduct(ProductID),
    CONSTRAINT FK_tbStockAdjustment_tbEmployee FOREIGN KEY (EmployeeID) REFERENCES tbEmployee(EmployeeID)
);
GO
