using AssigementOOADWinForms.Models;
using AssigementOOADWinForms.Repositries;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigementOOADWinForms.Services
{
    public class PaymentService
    {
        private readonly PaymentRepository _repo = new();
        public void SavePayment(Payment model) => _repo.Save(model);
        public DataTable GetAllPayments() => _repo.GetAllPayment();
    }
}
