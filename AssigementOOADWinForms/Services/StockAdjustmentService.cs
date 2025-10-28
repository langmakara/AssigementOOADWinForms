using System;
using System.Collections.Generic;
using AssigementOOADWinForms.Models;
using AssigementOOADWinForms.Repositories;

namespace AssigementOOADWinForms.Services
{
    public class StockAdjustmentService
    {
        private readonly StockAdjustmentRepository _repo;

        public StockAdjustmentService()
        {
            _repo = new StockAdjustmentRepository();
        }

        // Get all adjustments
        public List<StockAdjustment> GetAllAdjustments()
        {
            return _repo.GetAll();
        }

        // Create a stock adjustment record
        public void RecordAdjustment(int productId, int employeeId, int quantity, string adjustmentType, string? reason = null)
        {
            if (quantity <= 0)
                throw new ArgumentException("Quantity must be greater than zero.");

            if (string.IsNullOrWhiteSpace(adjustmentType))
                throw new ArgumentException("AdjustmentType is required.");

            var adjustment = new StockAdjustment
            {
                ProductID = productId,
                EmployeeID = employeeId,
                AdjustmentType = adjustmentType, // e.g., "Broken", "Lost", "Mismatch"
                Quantity = quantity,
                Reason = reason,
                AdjustmentDate = DateTime.Now
            };

            _repo.Save(adjustment);
        }

        // Delete adjustment
        public void DeleteAdjustment(int adjustmentId)
        {
            _repo.Delete(adjustmentId);
        }
    }
}
