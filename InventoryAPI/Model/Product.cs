using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryAPI.Model;
namespace InventoryAPI.Model;
[Table("tbProduct")]
public class Product
{
    [Key]
    public int ProductID { get; set; }

    [Required, StringLength(150)]
    public string ProductName { get; set; }

    public int SupplierID { get; set; }
    [ForeignKey("SupplierID")]
    public Supplier Supplier { get; set; }

    [Required, Column(TypeName = "decimal(18,2)")]
    public decimal UnitPrice { get; set; }

    public int QuantityInStock { get; set; } = 0;
    public int ReorderLevel { get; set; } = 0;

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    // Navigation
    public ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
    public ICollection<InvoiceDetail> InvoiceDetails { get; set; }
    public ICollection<InventoryTransaction> InventoryTransactions { get; set; }
    public ICollection<StockAdjustment> StockAdjustments { get; set; }
}
