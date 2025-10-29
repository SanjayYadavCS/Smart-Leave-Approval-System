using SLAS.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace SLAS.Models.Entities
{
    public class Leave
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [Required]
        [MaxLength(500)]
        public string Reason { get; set; }
        public LeaveType LeaveType { get; set; }
        public LeaveStatus LeaveStatus { get; set; }
        public DateTime AppliedOn { get; set; }
        [MaxLength(500)]
        public string Comment { get; set; }
        public int LastUpdatedBy { get; set; }
    }
}
