namespace AssigementOOADWinForms.Models
{
    public class InventoryTransaction
    {
        private int _transactionID;
        private int _productID;
        private string _transactionType = string.Empty;
        private int _quantityChange;
        private DateTime _transactionDate = DateTime.Now;
        private string? _productName;
        private decimal _productUnitPrice;

        public int TransactionID
        {
            get => _transactionID;
            set
            {
                if (value < 0)
                    throw new ArgumentException("TransactionID cannot be negative.");
                _transactionID = value;
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

        public string TransactionType
        {
            get => _transactionType;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("TransactionType is required.");
                // Optional: validate type is one of allowed types
                _transactionType = value.Trim();
            }
        }

        public int QuantityChange
        {
            get => _quantityChange;
            set
            {
                if (value == 0)
                    throw new ArgumentException("QuantityChange cannot be zero.");
                _quantityChange = value;
            }
        }

        public DateTime TransactionDate
        {
            get => _transactionDate;
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("TransactionDate cannot be in the future.");
                _transactionDate = value;
            }
        }

        public string? ProductName
        {
            get => _productName;
            internal set => _productName = value; // only repository/service can set it
        }

        public decimal ProductUnitPrice
        {
            get => _productUnitPrice;
            internal set
            {
                if (value < 0)
                    throw new ArgumentException("ProductUnitPrice cannot be negative.");
                _productUnitPrice = value;
            }
        }

    }
}
