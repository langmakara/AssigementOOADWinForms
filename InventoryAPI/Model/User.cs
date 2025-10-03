using System.Collections.Generic;
using InventoryAPI.Model;

namespace InventoryAPI.Model
{
    public class User
    {
        public int UserID { get; set; }

        public string Username { get; set; }
        public string PasswordHash { get; set; }

        // Optional: extra fields
        public string Email { get; set; }
        public string Role { get; set; }   // e.g., Admin, Staff, Manager
        public bool IsActive { get; set; } = true;

        // Navigation property
        public ICollection<AuditLog> AuditLogs { get; set; } = new List<AuditLog>();
    }
}
