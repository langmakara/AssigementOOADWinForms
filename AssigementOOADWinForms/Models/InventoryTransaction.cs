using System;
using System.ComponentModel.DataAnnotations;

namespace AssigementOOADWinForms.Models
{
    public class InventoryTransaction
    {
        [Key]  // ✅ Primary key
        public int TransactionID { get; set; }

        public int ProductID { get; set; }
        public string TransactionType { get; set; } // e.g., "IN", "OUT"
        public int QuantityChange { get; set; }
        public DateTime TransactionDate { get; set; }
        public int? ReferenceID { get; set; }

        // Navigation property
        public Product Product { get; set; }
    }
}
