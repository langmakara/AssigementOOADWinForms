using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigementOOADWinForms.DTOs
{
    public class PurchaseOrderDto
    {
        public int PurchaseID { get; set; }
        public int? SupplierID { get; set; }
        public int? EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string SupplierName { get; set; }
        public string EmployeeName { get; set; }
    }
}
