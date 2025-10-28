namespace AssigementOOADWinForms.Models
{
    public class Product
    {
        private int _productID;
        private string _productName = string.Empty;
        private int? _supplierID;
        private string _supplierName = string.Empty;
        private decimal _unitPrice;
        private int _quantityInStock;

        public int ProductID
        {
            get => _productID;
            set
            {
                if (value < 0)
                    throw new ArgumentException("ProductID cannot be negative.");
                _productID = value;
            }
        }

        public string ProductName
        {
            get => _productName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("ProductName cannot be empty.");
                _productName = value.Trim();
            }
        }

        public int? SupplierID
        {
            get => _supplierID;
            set
            {
                if (value < 0)
                    throw new ArgumentException("SupplierID cannot be negative.");
                _supplierID = value;
            }
        }

        public string SupplierName
        {
            get => _supplierName;
            set => _supplierName = value?.Trim() ?? string.Empty;
        }

        public decimal UnitPrice
        {
            get => _unitPrice;
            set
            {
                if (value < 0)
                    throw new ArgumentException("UnitPrice cannot be negative.");
                _unitPrice = value;
            }
        }

        public int QuantityInStock
        {
            get => _quantityInStock;
            set
            {
                if (value < 0)
                    throw new ArgumentException("QuantityInStock cannot be negative.");
                _quantityInStock = value;
            }
        }
        public decimal GetStockValue() => UnitPrice * QuantityInStock;
    }
}
