using System;
using System.ComponentModel.DataAnnotations;

namespace AssigementOOADWinForms.Models
{
    public class AuditLog
    {
        [Key]   // ✅ Marks this as Primary Key
        public int LogID { get; set; }

        public int UserID { get; set; }
        public string Action { get; set; }
        public string TableName { get; set; }
        public int? RecordID { get; set; }
        public DateTime ActionDate { get; set; }

        // Navigation property
        public User User { get; set; }
    }
}
