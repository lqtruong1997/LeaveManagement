using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Service
{
    public class LeaveRequestDTO
    {
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int NumberOfDay { get; set; }
        public int LeaveTypeId { get; set; }
        public string LeaveType { get; set; }
    }
}
