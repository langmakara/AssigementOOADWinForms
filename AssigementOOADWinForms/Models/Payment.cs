using System;

namespace AssigementOOADWinForms.Models
{
    public class Payment
    {
        private int _paymentID;
        private int _invoiceID;
        private DateTime _paymentDate = DateTime.Now;
        private string _paymentMethod = string.Empty;
        private decimal _amountPaid;

        public int PaymentID
        {
            get => _paymentID;
            set
            {
                if (value < 0)
                    throw new ArgumentException("PaymentID cannot be negative.");
                _paymentID = value;
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

        public DateTime PaymentDate
        {
            get => _paymentDate;
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("PaymentDate cannot be in the future.");
                _paymentDate = value;
            }
        }

        public string PaymentMethod
        {
            get => _paymentMethod;
            set
            {
                var allowedMethods = new[] { "Cash", "Credit Card", "Bank Transfer" };
                if (string.IsNullOrWhiteSpace(value) || !allowedMethods.Contains(value))
                    throw new ArgumentException($"PaymentMethod must be one of: {string.Join(", ", allowedMethods)}.");
                _paymentMethod = value;
            }
        }

        public decimal AmountPaid
        {
            get => _amountPaid;
            set
            {
                if (value < 0)
                    throw new ArgumentException("AmountPaid cannot be negative.");
                _amountPaid = value;
            }
        }

    }
}
