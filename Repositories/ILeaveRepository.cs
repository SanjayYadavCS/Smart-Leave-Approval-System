using SLAS.Models.Entities;

namespace SLAS.Repositories
{
    public interface ILeaveRepository
    {
        Task<Leave> GetLeaveById(int leaveId);
        Task<Leave> AddLeaveRequest(Leave leave);
        Task<Leave> UpdateLeaveRequest(Leave leave);
        Task<bool> DeleteLeaveRequest(int leaveId);
        Task<List<Leave>> GetAllLeaves();
        Task<List<Leave>> GetAllLeavesByEmployee(int emplyoeeId);
    }
}
