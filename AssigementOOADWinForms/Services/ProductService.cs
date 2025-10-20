using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssigementOOADWinForms.DTOs;
using AssigementOOADWinForms.Repositories;

namespace AssigementOOADWinForms.Services
{
    public class ProductService
    {
        private ProductRepository _repo = new();
        public List<ProductDto> GetProductIDAndName() => _repo.GetIDandName();
        public List<ProductDto> GetProductLowStock() => _repo.GetProductLowStock();
    }
}
