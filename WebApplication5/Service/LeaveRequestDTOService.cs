using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.Models;

namespace WebApplication5.Service
{
    public class LeaveRequestDTOService
    {
        private readonly LeaveRequestDataAccessLayer _leaveRequest = new LeaveRequestDataAccessLayer();
        private readonly LeaveTypesDataAccessLayer _leaveTypes = new LeaveTypesDataAccessLayer();

        public IEnumerable<LeaveRequestDTO> GetLeaveRequests(string startDate, string endDate, int leaveTypeId)
        {
            var leaveRequests = _leaveRequest.GetLeaveRequests(startDate, endDate, leaveTypeId);

            return leaveRequests.Select(leaveRequest => new LeaveRequestDTO
                {
                    StartDate = Utility.DateToString(leaveRequest.StartDate),
                    EndDate = Utility.DateToString(leaveRequest.EndDate),
                    LeaveType = _leaveTypes.GetLeaveTypeName(leaveRequest.LeaveTypeId),
                    NumberOfDay = Utility.GetNumberOfDay(leaveRequest.StartDate, leaveRequest.EndDate),
                    LeaveTypeId = leaveRequest.LeaveTypeId
                })
                .ToList();
        }
    }
}
