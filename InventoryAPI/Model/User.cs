using System.ComponentModel.DataAnnotations;
using InventoryAPI.Enum;
namespace InventoryAPI.Model
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required, MaxLength(50)]
        public string Username { get; set; }

        [Required, MaxLength(255)]
        public string PasswordHash { get; set; }

        [EmailAddress, MaxLength(100)]
        public string Email { get; set; }

        [Required]
        public UserRole Role { get; set; } = UserRole.Admin;

        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public ICollection<AuditLog> AuditLogs { get; set; } = new List<AuditLog>();
    }
}
