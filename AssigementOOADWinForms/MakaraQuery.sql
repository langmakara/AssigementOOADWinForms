-- 1. Users (System login)
CREATE TABLE tbUser (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(50) UNIQUE NOT NULL,
    PasswordHash VARCHAR(255) NOT NULL,
    Role VARCHAR(50) CHECK (Role IN ('Admin','Manager','Staff')) NOT NULL,
    CreatedAt DATETIME DEFAULT GETDATE()
);

-- 2. Employees
CREATE TABLE tbEmployee (
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeName VARCHAR(150) NOT NULL,
    Phone VARCHAR(50),
    Email VARCHAR(100),
    Address VARCHAR(255),
    Position VARCHAR(100),
    HireDate DATE DEFAULT GETDATE()
);

-- 3. Category
CREATE TABLE tbCategory (
    CategoryID INT IDENTITY(1,1) PRIMARY KEY,
    CategoryName VARCHAR(100) NOT NULL,
    Description VARCHAR(255)
);

-- 4. Supplier
CREATE TABLE tbSupplier (
    SupplierID INT IDENTITY(1,1) PRIMARY KEY,
    SupplierName VARCHAR(150) NOT NULL,
    ContactName VARCHAR(100),
    Phone VARCHAR(50),
    Email VARCHAR(100),
    Address VARCHAR(255)
);

-- 5. Customer
CREATE TABLE tbCustomer (
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerName VARCHAR(150) NOT NULL,
    Phone VARCHAR(50),
    Email VARCHAR(100),
    Address VARCHAR(255)
);

-- 6. Product
CREATE TABLE tbProduct (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName VARCHAR(150) NOT NULL,
    CategoryID INT FOREIGN KEY REFERENCES tbCategory(CategoryID),
    SupplierID INT FOREIGN KEY REFERENCES tbSupplier(SupplierID),
    UnitPrice DECIMAL(18,2) NOT NULL,
    QuantityInStock INT NOT NULL DEFAULT 0,
    ReorderLevel INT DEFAULT 0,
    CreatedAt DATETIME DEFAULT GETDATE()
);

-- 7. Purchase Order (Stock In)
CREATE TABLE tbPurchaseOrder (
    PurchaseID INT IDENTITY(1,1) PRIMARY KEY,
    SupplierID INT FOREIGN KEY REFERENCES tbSupplier(SupplierID),
    EmployeeID INT FOREIGN KEY REFERENCES tbEmployee(EmployeeID),
    OrderDate DATETIME DEFAULT GETDATE(),
    TotalAmount DECIMAL(18,2)
);

-- 8. Purchase Order Detail
CREATE TABLE tbPurchaseOrderDetail (
    PurchaseDetailID INT IDENTITY(1,1) PRIMARY KEY,
    PurchaseID INT FOREIGN KEY REFERENCES tbPurchaseOrder(PurchaseID),
    ProductID INT FOREIGN KEY REFERENCES tbProduct(ProductID),
    Quantity INT NOT NULL,
    UnitPrice DECIMAL(18,2) NOT NULL
);

-- 9. Sales Order (Stock Out)
CREATE TABLE tbSalesOrder (
    SalesID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerID INT FOREIGN KEY REFERENCES tbCustomer(CustomerID),
    EmployeeID INT FOREIGN KEY REFERENCES tbEmployee(EmployeeID),
    OrderDate DATETIME DEFAULT GETDATE(),
    TotalAmount DECIMAL(18,2)
);

-- 10. Sales Order Detail
CREATE TABLE tbSalesOrderDetail (
    SalesDetailID INT IDENTITY(1,1) PRIMARY KEY,
    SalesID INT FOREIGN KEY REFERENCES tbSalesOrder(SalesID),
    ProductID INT FOREIGN KEY REFERENCES tbProduct(ProductID),
    Quantity INT NOT NULL,
    UnitPrice DECIMAL(18,2) NOT NULL
);

-- 11. Inventory Transaction (Track stock changes)
CREATE TABLE tbInventoryTransaction (
    TransactionID INT IDENTITY(1,1) PRIMARY KEY,
    ProductID INT FOREIGN KEY REFERENCES tbProduct(ProductID),
    TransactionType VARCHAR(50) CHECK (TransactionType IN ('Purchase','Sale','Adjustment')),
    QuantityChange INT NOT NULL,
    TransactionDate DATETIME DEFAULT GETDATE(),
    ReferenceID INT NULL -- Can be PurchaseID or SalesID
);

-- 12. Payment (for Sales Orders)
CREATE TABLE tbPayment (
    PaymentID INT IDENTITY(1,1) PRIMARY KEY,
    SalesID INT FOREIGN KEY REFERENCES tbSalesOrder(SalesID),
    PaymentDate DATETIME DEFAULT GETDATE(),
    PaymentMethod VARCHAR(50) CHECK (PaymentMethod IN ('Cash','Credit Card','Bank Transfer')),
    AmountPaid DECIMAL(18,2) NOT NULL
);

-- 13. Stock Adjustment (Manual correction)
CREATE TABLE tbStockAdjustment (
    AdjustmentID INT IDENTITY(1,1) PRIMARY KEY,
    ProductID INT FOREIGN KEY REFERENCES tbProduct(ProductID),
    EmployeeID INT FOREIGN KEY REFERENCES tbEmployee(EmployeeID),
    AdjustmentType VARCHAR(50) CHECK (AdjustmentType IN ('Increase','Decrease')),
    Quantity INT NOT NULL,
    Reason VARCHAR(255),
    AdjustmentDate DATETIME DEFAULT GETDATE()
);

-- 14. Audit Log (track system activity)
CREATE TABLE tbAuditLog (
    LogID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT FOREIGN KEY REFERENCES tbUser(UserID),
    Action VARCHAR(255) NOT NULL,
    TableName VARCHAR(100),
    RecordID INT,
    ActionDate DATETIME DEFAULT GETDATE()
);