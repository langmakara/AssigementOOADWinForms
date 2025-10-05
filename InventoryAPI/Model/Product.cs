using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryAPI.Model;

namespace InventoryAPI.Model;
public class Product
{
    public int ProductID { get; set; }
    public string ProductName { get; set; }
    public int CategoryID { get; set; }
    public int SupplierID { get; set; }
    public decimal UnitPrice { get; set; }
    public int QuantityInStock { get; set; }
    public int ReorderLevel { get; set; }
    public String ImageUrl { get; set; }
    public DateTime CreatedAt { get; set; }
    public Category Category { get; set; }
    public Supplier Supplier { get; set; }
    public ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
    public ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }
    public ICollection<InventoryTransaction> InventoryTransactions { get; set; }
    public ICollection<StockAdjustment> StockAdjustments { get; set; }
}
