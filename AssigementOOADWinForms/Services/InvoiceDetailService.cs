using AssigementOOADWinForms.DTOs.AssigementOOADWinForms.DTOs;
using AssigementOOADWinForms.Models;
using AssigementOOADWinForms.Repositries;
namespace AssigementOOADWinForms.Services
{
    public class InvoiceDetailService
    {

        private readonly InvoiceDetailRepository? _repo = new();
        public List<InvoiceDetailDto> GetAllInvoiceDetails() => _repo.GetAll();
        public int SaveInvoiceDetailToDatabase(InvoiceDetail model) => _repo.SaveInvoiceDetail(model);
        public void DeleteInvoiceDetail(int ID) => _repo.Delete(ID);
    }
}
