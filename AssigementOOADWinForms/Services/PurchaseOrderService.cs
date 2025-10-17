using AssigementOOADWinForms.DTOs;
using AssigementOOADWinForms.Models;
using AssigementOOADWinForms.Repositories;
using AssigementOOADWinForms.Repositries;

namespace AssigementOOADWinForms.Services
{
     public class PurchaseOrderService
    {
        private readonly PurchaseOrderRepository _repo = new();
        public List<PurchaseOrder> GetAllPurchaseOrders() => _repo.GetAllPurchaseOrders();
        public void SavePurchaseOrder(PurchaseOrder model) => _repo.Save(model);
        public void RemovePurchaseOrder(int purchaseId) => _repo.Delete(purchaseId);

    }
}
