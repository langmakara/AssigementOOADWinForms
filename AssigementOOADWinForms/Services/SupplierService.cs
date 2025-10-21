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
    public class SupplierService
    {
        private readonly SupplierRepository _repo = new();
        public void SaveSupplier(Supplier model) => _repo.Save(model);
        public DataTable GetAllSuppliers() => _repo.GetAllSupplier();
    }
}
