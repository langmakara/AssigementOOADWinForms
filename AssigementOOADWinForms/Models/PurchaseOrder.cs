namespace AssigementOOADWinForms.Models
{
    public class PurchaseOrder
    {
        public int PurchaseID { get; set; }
        public int? SupplierID { get; set; }
        public string SupplierName { get; set; }
        public int? EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
