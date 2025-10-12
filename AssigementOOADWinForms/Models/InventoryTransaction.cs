namespace AssigementOOADWinForms.Models
{
    public class InventoryTransaction
    {
        public int TransactionID { get; set; }
        public int ProductID { get; set; }
        public string TransactionType { get; set; }
        public int QuantityChange { get; set; }
        public DateTime TransactionDate { get; set; }
        public int? ReferenceID { get; set; }
    }
}
