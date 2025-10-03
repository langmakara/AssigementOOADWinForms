using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryAPI.Model;

public class SalesOrder
{
    [Key]
    public int SalesID { get; set; }
    public int CustomerID { get; set; }
    public int EmployeeID { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }

    public Customer Customer { get; set; }
    public Employee Employee { get; set; }
    public ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }
    public ICollection<Payment> Payments { get; set; }
}
