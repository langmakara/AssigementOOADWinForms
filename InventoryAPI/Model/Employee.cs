using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryAPI.Model;

public class Employee
{
    public int EmployeeID { get; set; }
    public string EmployeeName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string Position { get; set; }
    public DateTime HireDate { get; set; }

    public ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    public ICollection<SalesOrder> SalesOrders { get; set; }
    public ICollection<StockAdjustment> StockAdjustments { get; set; }
}
