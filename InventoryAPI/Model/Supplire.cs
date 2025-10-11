using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryAPI.Model;

[Table("tbSupplier")]
public class Supplier
{
    [Key]
    public int SupplierID { get; set; }

    [Required, StringLength(150)]
    public string SupplierName { get; set; }

    [StringLength(100)]
    public string ContactName { get; set; }

    [StringLength(50)]
    public string Phone { get; set; }

    [StringLength(100)]
    public string Email { get; set; }

    [StringLength(255)]
    public string Address { get; set; }

    // Navigation
    public ICollection<Product> Products { get; set; }
    public ICollection<PurchaseOrder> PurchaseOrders { get; set; }
}