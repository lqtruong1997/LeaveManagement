using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeaveManagementSPA.Models;

namespace LeaveManagementSPA.ViewModels
{
    public class HolidayViewModels
    {
        public int NumberOfDay { get; set; }
        public string DisplayName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public HolidayViewModels(Holiday holiday)
        {
            this.DisplayName = holiday.DisplayName;
            this.StartDate = Utility.DateToString(holiday.StartDate);
            this.EndDate = Utility.DateToString(holiday.EndDate);
            this.NumberOfDay = Utility.GetNumberOfDay(holiday.StartDate, holiday.EndDate);
        }
    }
}
