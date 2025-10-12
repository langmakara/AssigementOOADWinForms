using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AssigementOOADWinForms.DTOs
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
    }


