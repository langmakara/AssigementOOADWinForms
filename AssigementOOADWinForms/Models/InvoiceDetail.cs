﻿namespace AssigementOOADWinForms.Models
{
    public class InvoiceDetail
    {
        public int InvoiceDetailID { get; set; }
        public int InvoiceID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
