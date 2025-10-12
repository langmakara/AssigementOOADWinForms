using System;
using System.Collections.Generic;

namespace InventoryAPI.DTOs
{
    public class InvoiceDto
    {
        public int InvoiceID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }

        // Include details if needed
        public List<InvoiceDetailDto> Details { get; set; }
    }

    public class InvoiceDetailDto
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
    public class CreateInvoiceDto
    {
        public string CustomerName { get; set; } = null!;
        public string CustomerPhone { get; set; } = null!;
        public int EmployeeID { get; set; }
        public List<CreateInvoiceDetailDto> Details { get; set; } = new();
    }

    public class CreateInvoiceDetailDto
    {
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }

}
