using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryAPI.Model;
public class Customer
{
    public int CustomerID { get; set; }
    public string CustomerName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }

    public ICollection<SalesOrder> SalesOrders { get; set; }
}
