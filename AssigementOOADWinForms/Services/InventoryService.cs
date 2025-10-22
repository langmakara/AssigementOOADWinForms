using System;
using System.Collections.Generic;
using AssigementOOADWinForms.DTOs;
using AssigementOOADWinForms.Models;
using AssigementOOADWinForms.Repositories;

namespace AssigementOOADWinForms.Services
{
    public class InventoryTransactionService
    {
        private readonly InventoryTransactionRepository _repo = new();

        public List<InventoryTransactionDto> GetAllTransactions() => _repo.GetAllTransactions();

        public void SaveTransaction(InventoryTransaction model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));
            if (model.ProductID <= 0) throw new ArgumentException("ProductID must be greater than 0.");
            if (string.IsNullOrWhiteSpace(model.TransactionType)) throw new ArgumentException("TransactionType is required.");
            if (model.QuantityChange == 0) throw new ArgumentException("QuantityChange cannot be zero.");
            if (model.TransactionDate == DateTime.MinValue) model.TransactionDate = DateTime.Now;

            _repo.SaveTransaction(model);
        }

        public void DeleteTransaction(int transactionId)
        {
            if (transactionId <= 0) throw new ArgumentException("TransactionID must be greater than 0.");
            _repo.DeleteTransaction(transactionId);
        }
    }
}
