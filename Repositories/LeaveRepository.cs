using Microsoft.EntityFrameworkCore;
using SLAS.Data;
using SLAS.Models.Entities;

namespace SLAS.Repositories
{
    public class LeaveRepository : ILeaveRepository
    {
        private readonly ILogger _logger;
        private readonly SLASContext _context;

        public LeaveRepository(ILogger logger, SLASContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<Leave> AddLeaveRequest(Leave leave)
        {
            try
            {
                await _context.Leaves.AddAsync(leave);
                return leave;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> DeleteLeaveRequest(int leaveId)
        {
            try
            {
                var leave = await _context.Leaves.FindAsync(leaveId);
                if (leave == null)
                {
                    throw new Exception("Leave Not Found");
                }

                _context.Leaves.Remove(leave);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<List<Leave>> GetAllLeaves()
        {
            try
            {
                
                return await _context.Leaves.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<Leave>> GetAllLeavesByEmployee(int emplyoeeId)
        {
            try
            {
                return await _context.Leaves.Where(x=>x.EmployeeId == emplyoeeId).ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Leave> GetLeaveById(int leaveId)
        {
            try
            {
                var leave = await _context.Leaves.FirstOrDefaultAsync(x=>x.Id == leaveId);

                return leave;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<Leave> UpdateLeaveRequest(Leave leave)
        {
            throw new NotImplementedException();
        }
    }
}
