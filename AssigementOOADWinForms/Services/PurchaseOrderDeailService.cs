using AssigementOOADWinForms.DTOs;
using AssigementOOADWinForms.Models;
using AssigementOOADWinForms.Repositories;
using AssigementOOADWinForms.Repositries;

namespace AssigementOOADWinForms.Services
{
    public class PurchaseOrderDeailService
    {
        // Implement business logic methods for PurchaseOrderDetail here
        private readonly PurchaseOrderDeailRepository _repo = new();
        public List<PurchaseOrderDetail> GetAllPurchaseOrderDetails() => _repo.GetAllPurchaseOrderDetails();
        public void SavePurchaseOrderDeail(PurchaseOrderDetail model) => _repo.Save(model);
        public void RemovePurchaseOrderDeail(int purchaseDetailID) => _repo.Delete(purchaseDetailID);

    }
}
