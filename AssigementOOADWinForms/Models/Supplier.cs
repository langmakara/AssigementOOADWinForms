namespace AssigementOOADWinForms.Models
{
    public class Supplier
    {
        private int _supplierID;
        private string _supplierName = string.Empty;
        private string? _contactName;
        private string? _phone;
        private string? _email;
        private string? _address;

        public int SupplierID
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
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("SupplierName cannot be empty.");
                _supplierName = value.Trim();
            }
        }

        public string? ContactName
        {
            get => _contactName;
            set => _contactName = value?.Trim();
        }

        public string? Phone
        {
            get => _phone;
            set => _phone = value?.Trim();
        }

        public string? Email
        {
            get => _email;
            set => _email = value?.Trim();
        }

        public string? Address
        {
            get => _address;
            set => _address = value?.Trim();
        }
    }
}
