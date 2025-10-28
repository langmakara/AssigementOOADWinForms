namespace AssigementOOADWinForms.Models
{
    public class StockAdjustment
    {
        private int _adjustmentID;
        private int _productID;
        private int _employeeID;
        private string _adjustmentType = string.Empty;
        private int _quantity;
        private string? _reason;
        private DateTime _adjustmentDate = DateTime.Now;

        public int AdjustmentID
        {
            get => _adjustmentID;
            set
            {
                if (value < 0)
                    throw new ArgumentException("AdjustmentID cannot be negative.");
                _adjustmentID = value;
            }
        }

        public int ProductID
        {
            get => _productID;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("ProductID must be greater than zero.");
                _productID = value;
            }
        }

        public int EmployeeID
        {
            get => _employeeID;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("EmployeeID must be greater than zero.");
                _employeeID = value;
            }
        }

        public string AdjustmentType
        {
            get => _adjustmentType;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("AdjustmentType is required.");
                _adjustmentType = value.Trim();
            }
        }

        public int Quantity
        {
            get => _quantity;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Quantity must be greater than zero.");
                _quantity = value;
            }
        }

        public string? Reason
        {
            get => _reason;
            set => _reason = value?.Trim();
        }

        public DateTime AdjustmentDate
        {
            get => _adjustmentDate;
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("AdjustmentDate cannot be in the future.");
                _adjustmentDate = value;
            }
        }
    }
}
