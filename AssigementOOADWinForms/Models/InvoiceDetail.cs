namespace AssigementOOADWinForms.Models
{
    public class InvoiceDetail
    {
        private int _invoiceDetailID;
        private int _invoiceID;
        private int _productID;
        private int _quantity;
        private decimal _unitPrice;

        public int InvoiceDetailID
        {
            get => _invoiceDetailID;
            set
            {
                if (value < 0)
                    throw new ArgumentException("InvoiceDetailID cannot be negative.");
                _invoiceDetailID = value;
            }
        }

        public int InvoiceID
        {
            get => _invoiceID;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("InvoiceID must be greater than zero.");
                _invoiceID = value;
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

        public decimal GetTotal() => Quantity * UnitPrice;
    }
}
