namespace AssigementOOADWinForms.DTOs
{
    public class InvoiceDto
    {
        public int InvoiceID { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerPhone { get; set; }
        public string? CustomerAddress { get; set; }
        // Foreign key and related display data
        public int EmployeeID { get; set; }
        public string? EmployeeName { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string? Status { get; set; }
    }
}
