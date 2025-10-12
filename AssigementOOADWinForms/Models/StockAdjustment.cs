namespace AssigementOOADWinForms.Models
{
    public class StockAdjustment
    {
        public int AdjustmentID { get; set; }
        public int ProductID { get; set; }
        public int EmployeeID { get; set; }
        public string AdjustmentType { get; set; }
        public int Quantity { get; set; }
        public string? Reason { get; set; }
        public DateTime AdjustmentDate { get; set; }
    }
}
