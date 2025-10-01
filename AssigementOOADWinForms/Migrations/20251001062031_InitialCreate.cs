using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssigementOOADWinForms.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbCategory",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbCategory", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "tbCustomer",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbCustomer", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "tbEmployee",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbEmployee", x => x.EmployeeID);
                });

            migrationBuilder.CreateTable(
                name: "tbSupplier",
                columns: table => new
                {
                    SupplierID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbSupplier", x => x.SupplierID);
                });

            migrationBuilder.CreateTable(
                name: "tbUser",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbUser", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "tbSalesOrder",
                columns: table => new
                {
                    SalesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbSalesOrder", x => x.SalesID);
                    table.ForeignKey(
                        name: "FK_tbSalesOrder_tbCustomer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "tbCustomer",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbSalesOrder_tbEmployee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "tbEmployee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbProduct",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    SupplierID = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QuantityInStock = table.Column<int>(type: "int", nullable: false),
                    ReorderLevel = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbProduct", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_tbProduct_tbCategory_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "tbCategory",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbProduct_tbSupplier_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "tbSupplier",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbPurchaseOrder",
                columns: table => new
                {
                    PurchaseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierID = table.Column<int>(type: "int", nullable: false),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbPurchaseOrder", x => x.PurchaseID);
                    table.ForeignKey(
                        name: "FK_tbPurchaseOrder_tbEmployee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "tbEmployee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbPurchaseOrder_tbSupplier_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "tbSupplier",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbAuditLog",
                columns: table => new
                {
                    LogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TableName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecordID = table.Column<int>(type: "int", nullable: true),
                    ActionDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbAuditLog", x => x.LogID);
                    table.ForeignKey(
                        name: "FK_tbAuditLog_tbUser_UserID",
                        column: x => x.UserID,
                        principalTable: "tbUser",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbPayment",
                columns: table => new
                {
                    PaymentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalesID = table.Column<int>(type: "int", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AmountPaid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SalesOrderSalesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbPayment", x => x.PaymentID);
                    table.ForeignKey(
                        name: "FK_tbPayment_tbSalesOrder_SalesOrderSalesID",
                        column: x => x.SalesOrderSalesID,
                        principalTable: "tbSalesOrder",
                        principalColumn: "SalesID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbInventoryTransaction",
                columns: table => new
                {
                    TransactionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuantityChange = table.Column<int>(type: "int", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReferenceID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbInventoryTransaction", x => x.TransactionID);
                    table.ForeignKey(
                        name: "FK_tbInventoryTransaction_tbProduct_ProductID",
                        column: x => x.ProductID,
                        principalTable: "tbProduct",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbSalesOrderDetail",
                columns: table => new
                {
                    SalesDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalesID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SalesOrderSalesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbSalesOrderDetail", x => x.SalesDetailID);
                    table.ForeignKey(
                        name: "FK_tbSalesOrderDetail_tbProduct_ProductID",
                        column: x => x.ProductID,
                        principalTable: "tbProduct",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbSalesOrderDetail_tbSalesOrder_SalesOrderSalesID",
                        column: x => x.SalesOrderSalesID,
                        principalTable: "tbSalesOrder",
                        principalColumn: "SalesID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbStockAdjustment",
                columns: table => new
                {
                    AdjustmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    AdjustmentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdjustmentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbStockAdjustment", x => x.AdjustmentID);
                    table.ForeignKey(
                        name: "FK_tbStockAdjustment_tbEmployee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "tbEmployee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbStockAdjustment_tbProduct_ProductID",
                        column: x => x.ProductID,
                        principalTable: "tbProduct",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbPurchaseOrderDetail",
                columns: table => new
                {
                    PurchaseOrderDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchaseOrderID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbPurchaseOrderDetail", x => x.PurchaseOrderDetailID);
                    table.ForeignKey(
                        name: "FK_tbPurchaseOrderDetail_tbProduct_ProductID",
                        column: x => x.ProductID,
                        principalTable: "tbProduct",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbPurchaseOrderDetail_tbPurchaseOrder_PurchaseOrderID",
                        column: x => x.PurchaseOrderID,
                        principalTable: "tbPurchaseOrder",
                        principalColumn: "PurchaseID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbAuditLog_UserID",
                table: "tbAuditLog",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_tbInventoryTransaction_ProductID",
                table: "tbInventoryTransaction",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_tbPayment_SalesOrderSalesID",
                table: "tbPayment",
                column: "SalesOrderSalesID");

            migrationBuilder.CreateIndex(
                name: "IX_tbProduct_CategoryID",
                table: "tbProduct",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_tbProduct_SupplierID",
                table: "tbProduct",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_tbPurchaseOrder_EmployeeID",
                table: "tbPurchaseOrder",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_tbPurchaseOrder_SupplierID",
                table: "tbPurchaseOrder",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_tbPurchaseOrderDetail_ProductID",
                table: "tbPurchaseOrderDetail",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_tbPurchaseOrderDetail_PurchaseOrderID",
                table: "tbPurchaseOrderDetail",
                column: "PurchaseOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_tbSalesOrder_CustomerID",
                table: "tbSalesOrder",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_tbSalesOrder_EmployeeID",
                table: "tbSalesOrder",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_tbSalesOrderDetail_ProductID",
                table: "tbSalesOrderDetail",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_tbSalesOrderDetail_SalesOrderSalesID",
                table: "tbSalesOrderDetail",
                column: "SalesOrderSalesID");

            migrationBuilder.CreateIndex(
                name: "IX_tbStockAdjustment_EmployeeID",
                table: "tbStockAdjustment",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_tbStockAdjustment_ProductID",
                table: "tbStockAdjustment",
                column: "ProductID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbAuditLog");

            migrationBuilder.DropTable(
                name: "tbInventoryTransaction");

            migrationBuilder.DropTable(
                name: "tbPayment");

            migrationBuilder.DropTable(
                name: "tbPurchaseOrderDetail");

            migrationBuilder.DropTable(
                name: "tbSalesOrderDetail");

            migrationBuilder.DropTable(
                name: "tbStockAdjustment");

            migrationBuilder.DropTable(
                name: "tbUser");

            migrationBuilder.DropTable(
                name: "tbPurchaseOrder");

            migrationBuilder.DropTable(
                name: "tbSalesOrder");

            migrationBuilder.DropTable(
                name: "tbProduct");

            migrationBuilder.DropTable(
                name: "tbCustomer");

            migrationBuilder.DropTable(
                name: "tbEmployee");

            migrationBuilder.DropTable(
                name: "tbCategory");

            migrationBuilder.DropTable(
                name: "tbSupplier");
        }
    }
}
