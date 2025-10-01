using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AssigementOOADWinForms.Models
{
    public class PurchaseOrder
    {
        [Key]  // ✅ Primary key
        public int PurchaseID { get; set; }

        public int SupplierID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }

        // Navigation properties
        public Supplier Supplier { get; set; }
        public Employee Employee { get; set; }
        public ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; } = new List<PurchaseOrderDetail>();
    }
}
