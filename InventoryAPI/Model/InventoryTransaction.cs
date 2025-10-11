using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryAPI.Model
{
    [Table("tbInventoryTransaction")]
    public class InventoryTransaction
    {
        [Key]
        public int TransactionID { get; set; }

        public int ProductID { get; set; }
        [ForeignKey("ProductID")]
        public Product Product { get; set; }

        [Required, StringLength(50)]
        public string TransactionType { get; set; } // Purchase, Sale, Adjustment

        [Required]
        public int QuantityChange { get; set; }

        public DateTime TransactionDate { get; set; } = DateTime.Now;

        public int? ReferenceID { get; set; }
    }
}
