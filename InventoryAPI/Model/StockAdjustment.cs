using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryAPI.Model;

public class StockAdjustment
{
    [Key]
    public int AdjustmentID { get; set; }
    public int ProductID { get; set; }
    public int EmployeeID { get; set; }
    public string AdjustmentType { get; set; }
    public int Quantity { get; set; }
    public string Reason { get; set; }
    public DateTime AdjustmentDate { get; set; }

    public Product Product { get; set; }
    public Employee Employee { get; set; }
}
