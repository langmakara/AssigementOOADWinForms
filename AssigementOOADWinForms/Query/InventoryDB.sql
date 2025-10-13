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
-- Product Table (denormalized)
-- =====================================
CREATE TABLE tbProduct (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName VARCHAR(150) NOT NULL,
    SupplierID INT,
    SupplierName VARCHAR(150),        -- denormalized
    SupplierPhone VARCHAR(50),       -- denormalized
    UnitPrice DECIMAL(18,2) NOT NULL,
    QuantityInStock INT DEFAULT 0,
    ReorderLevel INT DEFAULT 0,
    CreatedAt DATETIME DEFAULT GETDATE()
);
GO

-- =====================================
-- Purchase Order Table (denormalized)
-- =====================================
CREATE TABLE tbPurchaseOrder (
    PurchaseID INT IDENTITY(1,1) PRIMARY KEY,
    SupplierID INT,
    SupplierName VARCHAR(150),       -- denormalized
    EmployeeID INT,
    EmployeeName VARCHAR(150),       -- denormalized
    OrderDate DATETIME DEFAULT GETDATE(),
    TotalAmount DECIMAL(18,2)
);
GO

-- =====================================
-- Purchase Order Detail Table (denormalized)
-- =====================================
CREATE TABLE tbPurchaseOrderDetail (
    PurchaseDetailID INT IDENTITY(1,1) PRIMARY KEY,
    PurchaseID INT NOT NULL,
    ProductID INT NOT NULL,
    ProductName VARCHAR(150),        -- denormalized
    Quantity INT NOT NULL,
    UnitPrice DECIMAL(18,2) NOT NULL
);
GO

-- =====================================
-- Invoice Table (denormalized)
-- =====================================
CREATE TABLE tbInvoice (
    InvoiceID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerName VARCHAR(50),
    CustomerPhone VARCHAR(50),
    EmployeeID INT,
    EmployeeName VARCHAR(150),       -- denormalized
    OrderDate DATETIME DEFAULT GETDATE(),
    Status VARCHAR(50) NOT NULL DEFAULT 'Pending',
    TotalAmount DECIMAL(18,2)
);
GO

-- =====================================
-- Invoice Detail Table (denormalized)
-- =====================================
CREATE TABLE tbInvoiceDetail (
    InvoiceDetailID INT IDENTITY(1,1) PRIMARY KEY,
    InvoiceID INT NOT NULL,
    ProductID INT NOT NULL,
    ProductName VARCHAR(150),        -- denormalized
    Quantity INT NOT NULL,
    UnitPrice DECIMAL(18,2) NOT NULL
);
GO

-- =====================================
-- Inventory Transaction Table (denormalized)
-- =====================================
CREATE TABLE tbInventoryTransaction (
    TransactionID INT IDENTITY(1,1) PRIMARY KEY,
    ProductID INT NOT NULL,
    ProductName VARCHAR(150),        -- denormalized
    ProductUnitPrice DECIMAL(18,2),  -- denormalized
    TransactionType VARCHAR(50) CHECK (TransactionType IN ('Purchase', 'Sale', 'Adjustment')),
    QuantityChange INT NOT NULL,
    TransactionDate DATETIME DEFAULT GETDATE(),
    ReferenceID INT
);
GO

-- =====================================
-- Payment Table (denormalized)
-- =====================================
CREATE TABLE tbPayment (
    PaymentID INT IDENTITY(1,1) PRIMARY KEY,
    InvoiceID INT NOT NULL,
    CustomerName VARCHAR(50),        -- denormalized
    InvoiceTotalAmount DECIMAL(18,2), -- denormalized
    PaymentDate DATETIME DEFAULT GETDATE(),
    PaymentMethod VARCHAR(50) CHECK (PaymentMethod IN ('Cash', 'Credit Card', 'Bank Transfer')),
    AmountPaid DECIMAL(18,2) NOT NULL
);
GO

-- =====================================
-- Stock Adjustment Table (denormalized)
-- =====================================
CREATE TABLE tbStockAdjustment (
    AdjustmentID INT IDENTITY(1,1) PRIMARY KEY,
    ProductID INT NOT NULL,
    ProductName VARCHAR(150),        -- denormalized
    EmployeeID INT NOT NULL,
    EmployeeName VARCHAR(150),       -- denormalized
    AdjustmentType VARCHAR(50) CHECK (AdjustmentType IN ('Increase', 'Decrease')),
    Quantity INT NOT NULL,
    Reason VARCHAR(255),
    AdjustmentDate DATETIME DEFAULT GETDATE()
);
GO
