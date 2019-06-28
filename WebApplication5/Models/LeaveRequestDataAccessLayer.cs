using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication5.Models
{
    public class LeaveRequestDataAccessLayer
    {
        private readonly TestDBContext _db = new TestDBContext();

        public IEnumerable<LeaveRequests> GetLeaveRequests(string startDate, string endDate, int leaveTypeId)
        {
            try
            {
                var start = DateTime.MinValue;
                var end = DateTime.MaxValue;
                if (startDate != null)
                {
                    start = Convert.ToDateTime(startDate);
                }

                if (endDate != null)
                {
                    end = Convert.ToDateTime(endDate);
                }

                return leaveTypeId != 0 ? 
                    _db.LeaveRequests.Where(t => t.StartDate >= start && t.StartDate <= end && t.LeaveTypeId == leaveTypeId) : 
                    _db.LeaveRequests.Where(t => t.StartDate >= start && t.StartDate <= end);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public LeaveRequests GetLeaveRequestById(string id)
        {
            try
            {
                var guid = Guid.Parse(id);
                return _db.LeaveRequests.Find(guid);
            }
            catch
            {
                throw;
            }
        }

        public int UpdateLeaveRequest(LeaveRequests leaveRequest)
        {
            try
            {
                _db.Entry(leaveRequest).State = EntityState.Modified;
                _db.SaveChanges();
                return 200;
            }
            catch
            {
                throw;
            }
        }

        public int DeleteLeaveRequest(string id)
        {
            try
            {
                var guid = Guid.Parse(id);
                var leaveRequest = _db.LeaveRequests.Find(guid);
                _db.Entry(leaveRequest).State = EntityState.Deleted;
                _db.SaveChanges();
                return 200;
            }
            catch 
            {
                throw;
            }
        }
    }
}
