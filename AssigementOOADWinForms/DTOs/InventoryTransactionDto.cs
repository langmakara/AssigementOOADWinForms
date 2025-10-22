using System;

namespace AssigementOOADWinForms.DTOs
{
    public class InventoryTransactionDto
    {
        public int TransactionID { get; set; }
        public int ProductID { get; set; }
        public string? ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public string TransactionType { get; set; } = string.Empty;
        public int QuantityChange { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
