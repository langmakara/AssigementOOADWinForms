using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InventoryAPI.Model
{
    [Table("tbInvoices")]
    public class Invoice
    {
        [Key]
        public int InvoiceID { get; set; }

        [StringLength(50)]
        public required string CustomerName { get; set; }

        [StringLength(50)]
        public required string CustomerPhone { get; set; }

        public int? EmployeeID { get; set; }
        [ForeignKey("EmployeeID")]
        public Employee? Employee { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; }

        // Navigation
        public required ICollection<InvoiceDetail> InvoiceDetails { get; set; }
        public ICollection<Payment?> Payments { get; set; }
    }
}
