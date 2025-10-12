namespace AssigementOOADWinForms.Models
{
    public class PurchaseOrder
    {
        public int PurchaseID { get; set; }
        public int? SupplierID { get; set; }
        public int? EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
