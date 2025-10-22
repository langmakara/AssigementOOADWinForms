using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssigementOOADWinForms.DTOs;
using AssigementOOADWinForms.Models;
using AssigementOOADWinForms.Repositories;

namespace AssigementOOADWinForms.Services
{
    public class ProductService
    {
        private ProductRepository _repo = new();
        public List<ProductDto> GetProductIDAndName() => _repo.GetIDandName();
        public List<ProductDto> GetProductLowStock() => _repo.GetProductLowStock();
        public List<ProductDto> GetProductOutOfStock() => _repo.GetProductOutOfStock();
        public void SaveProduct(Product model) => _repo.Save(model);
        public DataTable GetAllProducts() => _repo.GetAllProduct();
    }
}
