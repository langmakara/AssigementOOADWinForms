using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace InventoryAPI.Model;
[Table("tbStockAdjustment")]
public class StockAdjustment
{
    [Key]
    public int AdjustmentID { get; set; }

    public int ProductID { get; set; }
    [ForeignKey("ProductID")]
    public required Product Product { get; set; }

    public int EmployeeID { get; set; }
    [ForeignKey("EmployeeID")]
    public Employee Employee { get; set; }

    [Required, StringLength(50)]
    public required string AdjustmentType { get; set; } // Increase, Decrease

    [Required]
    public int Quantity { get; set; }

    [StringLength(255)]
    public required string Reason { get; set; }
    public DateTime AdjustmentDate { get; set; } = DateTime.Now;
}