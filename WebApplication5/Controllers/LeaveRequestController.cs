using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models;
using WebApplication5.Service;

namespace WebApplication5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveRequestController : ControllerBase
    {
        private readonly LeaveRequestDataAccessLayer _leaveRequest = new LeaveRequestDataAccessLayer();
        private readonly LeaveTypesDataAccessLayer _leaveTypes = new LeaveTypesDataAccessLayer();
        private readonly LeaveRequestDTOService _leaveRequestDto = new LeaveRequestDTOService();

        [HttpGet]
        [Route("GetLeaveRequest")]
        public IEnumerable<LeaveRequestDTO> GetLeaveRequests(string startDate, string endDate, int leaveTypeId)
        {
            return _leaveRequestDto.GetLeaveRequests(startDate, endDate, leaveTypeId);
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