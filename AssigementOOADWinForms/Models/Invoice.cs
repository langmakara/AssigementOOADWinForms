namespace AssigementOOADWinForms.Models
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerPhone { get; set; }
        public string? CustomerAddress { get; set; }
        public int? EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public List<InvoiceDetail> Details { get; set; } = new();
    }
}
