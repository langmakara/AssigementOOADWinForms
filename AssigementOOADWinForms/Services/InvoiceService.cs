using AssigementOOADWinForms.Repositories;
using AssigementOOADWinForms.DTOs;
using AssigementOOADWinForms.Models;

namespace AssigementOOADWinForms.Services
{
    public class InvoiceService
    {
        private readonly InvoiceRepository _repo = new();

        public List<InvoiceDto> GetAllInvoices() => _repo.GetAll();
        public void SaveInvoice(Invoice model) => _repo.Save(model);
        public void RemoveInvoice(int invoiceId) => _repo.Delete(invoiceId);
    }
}
