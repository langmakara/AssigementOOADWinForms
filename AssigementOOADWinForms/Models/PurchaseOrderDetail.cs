namespace AssigementOOADWinForms.Models
{
    public class PurchaseOrderDetail
    {
        private int _purchaseDetailID;
        private int _purchaseID;
        private int _productID;
        private string? _productName;
        private int _quantity;
        private decimal _unitPrice;

        public int PurchaseDetailID
        {
            get => _purchaseDetailID;
            set
            {
                if (value < 0)
                    throw new ArgumentException("PurchaseDetailID cannot be negative.");
                _purchaseDetailID = value;
            }
        }

        public int PurchaseID
        {
            get => _purchaseID;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("PurchaseID must be greater than zero.");
                _purchaseID = value;
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

        public string? ProductName
        {
            get => _productName;
            set => _productName = value?.Trim();
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

    }
}
