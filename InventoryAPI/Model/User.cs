using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace InventoryAPI.Model
{
    [Table("tbUser")]
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required, StringLength(50)]
        public string Username { get; set; }

        [Required, StringLength(255)]
        public string PasswordHash { get; set; }

        [Required, StringLength(50)]
        public string Role { get; set; } // Admin, Manager, Staff

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
