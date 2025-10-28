using System;

namespace AssigementOOADWinForms.Models
{
    public class User
    {
        private int _userID;
        private string _username = string.Empty;
        private string _passwordHash = string.Empty;
        private string _role = string.Empty;
        private DateTime _createdAt = DateTime.Now;

        public int UserID
        {
            get => _userID;
            set
            {
                if (value < 0)
                    throw new ArgumentException("UserID cannot be negative.");
                _userID = value;
            }
        }

        public string Username
        {
            get => _username;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Username cannot be empty.");
                _username = value.Trim();
            }
        }

        public string PasswordHash
        {
            get => _passwordHash;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("PasswordHash cannot be empty.");
                _passwordHash = value;
            }
        }

        public string Role
        {
            get => _role;
            set
            {
                var allowedRoles = new[] { "Admin", "Manager", "Staff" };
                if (string.IsNullOrWhiteSpace(value) || !allowedRoles.Contains(value))
                    throw new ArgumentException($"Role must be one of: {string.Join(", ", allowedRoles)}.");
                _role = value;
            }
        }

        public DateTime CreatedAt
        {
            get => _createdAt;
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("CreatedAt cannot be in the future.");
                _createdAt = value;
            }
        }
    }
}
