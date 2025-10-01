using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigementOOADWinForms.Models;

public class Payment
{
    public int PaymentID { get; set; }
    public int SalesID { get; set; }
    public DateTime PaymentDate { get; set; }
    public string PaymentMethod { get; set; }
    public decimal AmountPaid { get; set; }

    public SalesOrder SalesOrder { get; set; }
}