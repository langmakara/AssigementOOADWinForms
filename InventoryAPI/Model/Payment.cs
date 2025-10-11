using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryAPI.Model;

[Table("tbPayment")]
public class Payment
{
    [Key]
    public int PaymentID { get; set; }

    public int InvoiceID { get; set; }
    [ForeignKey("InvoiceID")]
    public Invoice Invoice { get; set; }

    public DateTime PaymentDate { get; set; } = DateTime.Now;

    [StringLength(50)]
    public string PaymentMethod { get; set; } // Cash, Credit Card, Bank Transfer

    [Required, Column(TypeName = "decimal(18,2)")]
    public decimal AmountPaid { get; set; }
}
