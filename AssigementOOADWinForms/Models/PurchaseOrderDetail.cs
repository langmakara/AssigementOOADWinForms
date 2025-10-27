namespace AssigementOOADWinForms.Models
{
    public class PurchaseOrderDetail
    {
        public int PurchaseDetailID { get; set; }
        public int PurchaseID { get; set; }
        public int ProductID { get; set; }
        public string? ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
