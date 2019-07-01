using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeaveManagementSPA.Models;
using LeaveManagementSPA.Repositories;

namespace LeaveManagementSPA.ViewModels
{
    public class LeaveRequestViewModels
    {
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int NumberOfDay { get; set; }
        public int LeaveTypeId { get; set; }
        public string LeaveType { get; set; }

        private readonly LeaveTypesRepository _leaveTypes = new LeaveTypesRepository();

        public LeaveRequestViewModels(LeaveRequests leaveRequest)
        {
            StartDate = Utility.DateToString(leaveRequest.StartDate);
            EndDate = Utility.DateToString(leaveRequest.EndDate);
            LeaveType = _leaveTypes.GetLeaveTypeName(leaveRequest.LeaveTypeId);
            NumberOfDay = Utility.GetNumberOfDay(leaveRequest.StartDate, leaveRequest.EndDate);
            LeaveTypeId = leaveRequest.LeaveTypeId;
        }
    }
}
