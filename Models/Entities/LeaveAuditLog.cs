using SLAS.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace SLAS.Models.Entities
{
    public class LeaveAuditLog
    {
        [Key]
        public int Id { get; set; }
        public LeaveStatus OldStatus { get; set; }
        public LeaveStatus NewStatus { get; set; }
        [MaxLength(500)]
        public string? Comment { get; set; }
        public DateTime ChangedOn { get; set; }
    }
}
