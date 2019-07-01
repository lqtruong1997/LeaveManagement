using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LeaveManagementSPA.Models;
using LeaveManagementSPA.Repositories;
using LeaveManagementSPA.ViewModels;

namespace LeaveManagementSPA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveRequestController : ControllerBase
    {
        private readonly LeaveRequestRepository _leaveRequest = new LeaveRequestRepository();
        private readonly LeaveTypesRepository _leaveTypes = new LeaveTypesRepository();

        [HttpGet]
        [Route("GetLeaveRequest")]
        public IEnumerable<LeaveRequestViewModels> GetLeaveRequests(string startDate, string endDate, int leaveTypeId)
        {
            var leaveRequests = _leaveRequest.GetLeaveRequests(startDate, endDate, leaveTypeId);

            return leaveRequests.Select(leaveRequest => new LeaveRequestViewModels(leaveRequest)).ToList();
        }

        [HttpGet]
        [Route("GetLeaveRequestById")]
        public LeaveRequests GetLeaveRequestById(string id)
        {
            return _leaveRequest.GetLeaveRequestById(id);
        }

        [HttpPut]
        [Route("UpdateLeaveRequest")]
        public int UpdateLeaveRequest([FromBody]LeaveRequests leaveRequest)
        {
            return _leaveRequest.UpdateLeaveRequest(leaveRequest);
        }

        [HttpDelete]
        [Route("DeleteLeaveRequest")]
        public int DeleteLeaveRequest([FromBody]string id)
        {
            return _leaveRequest.DeleteLeaveRequest(id);
        }

        [HttpGet]
        [Route("GetLeaveTypes")]
        public IEnumerable<LeaveTypes> GetLeaveTypes()
        {
            return _leaveTypes.GetLeaveTypes();
        }

        [HttpGet]
        [Route("GetLeaveTypeById")]
        public LeaveTypes GetLeaveTypeById(int id)
        {
            return _leaveTypes.GetLeaveTypesById(id);
        }
    }
}