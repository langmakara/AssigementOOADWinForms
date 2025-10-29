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
        public List<InvoiceDto> GetInvoiceIDAndName() => _repo.GetAllInvoicesLatestFirst();
        public List<InvoiceDto> GetPendingInvoices()
        {
            return _repo.GetPendingInvoices();
        }
        public void MarkAsDelivered(int invoiceId)
        {
            _repo.MarkAsDelivered(invoiceId);
        }
        public void MarkInvoicesAsDelivered(List<int> invoiceIds)
        {
            foreach (var id in invoiceIds)
            {
                _repo.MarkAsDelivered(id);
            }
        }
    }
}
