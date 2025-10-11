using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace InventoryAPI.Model;
[Table("tbEmployee")]
public class Employee
{
    [Key]
    public int EmployeeID { get; set; }

    [Required, StringLength(150)]
    public required string EmployeeName { get; set; }

    [StringLength(50)]
    public required string Phone { get; set; }

    [StringLength(100)]
    public string? Email { get; set; }

    [StringLength(255)]
    public required string Address { get; set; }

    [StringLength(100)]
    public required string Position { get; set; }

    public DateTime HireDate { get; set; } = DateTime.Now;

    // Navigation
    public required ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    public required ICollection<Invoice> Invoices { get; set; }
    public required ICollection<StockAdjustment> StockAdjustments { get; set; }
}
