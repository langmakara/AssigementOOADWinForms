using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigementOOADWinForms.Models;

public class SalesOrderDetail
{
    [Key]
    public int SalesDetailID { get; set; }
    public int SalesID { get; set; }
    public int ProductID { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }

    public SalesOrder SalesOrder { get; set; }
    public Product Product { get; set; }
}
