namespace AssigementOOADWinForms.Models
{
    public class Invoice
    {
        private int _invoiceID;
        private string _customerName = string.Empty;
        private DateTime _orderDate = DateTime.Now;

        public int InvoiceID
        {
            get => _invoiceID;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Invoice ID cannot be negative.");
                _invoiceID = value;
            }
        }

        public string CustomerName
        {
            get => _customerName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Customer name cannot be empty.");
                _customerName = value.Trim();
            }
        }

        public string CustomerPhone { get; set; } = string.Empty;
        public string CustomerAddress { get; set; } = string.Empty;

        public int? EmployeeID { get; set; }

        public DateTime OrderDate
        {
            get => _orderDate;
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("Order date cannot be in the future.");
                _orderDate = value;
            }
        }
    }
}
