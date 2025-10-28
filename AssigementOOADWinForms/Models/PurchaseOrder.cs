namespace AssigementOOADWinForms.Models
{
    public class PurchaseOrder
    {
        private int _purchaseID;
        private int? _supplierID;
        private string _supplierName = string.Empty;
        private int? _employeeID;
        private string _employeeName = string.Empty;
        private DateTime _orderDate = DateTime.Now;
        private decimal _totalAmount;

        public int PurchaseID
        {
            get => _purchaseID;
            set
            {
                if (value < 0)
                    throw new ArgumentException("PurchaseID cannot be negative.");
                _purchaseID = value;
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

        public int? EmployeeID
        {
            get => _employeeID;
            set
            {
                if (value < 0)
                    throw new ArgumentException("EmployeeID cannot be negative.");
                _employeeID = value;
            }
        }

        public string EmployeeName
        {
            get => _employeeName;
            set => _employeeName = value?.Trim() ?? string.Empty;
        }

        public DateTime OrderDate
        {
            get => _orderDate;
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("OrderDate cannot be in the future.");
                _orderDate = value;
            }
        }

        public decimal TotalAmount
        {
            get => _totalAmount;
            set
            {
                if (value < 0)
                    throw new ArgumentException("TotalAmount cannot be negative.");
                _totalAmount = value;
            }
        }
    }
}
