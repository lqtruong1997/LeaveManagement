using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.Models;

namespace WebApplication5.Service
{
    public class HolidayDTOService
    {
        
        private readonly HolidayDataAccessLayer _holiday = new HolidayDataAccessLayer();

        public IEnumerable<HolidayDTO> GetUpcomingHoliday(int numberOfHoliday)
        {
            var upcomingHoliday = _holiday.GetUpcomingHoliday(numberOfHoliday);

            return upcomingHoliday.Select(holiday => new HolidayDTO
                {
                    DisplayName = holiday.DisplayName,
                    StartDate = Utility.DateToString(holiday.StartDate),
                    EndDate = Utility.DateToString(holiday.EndDate),
                    NumberOfDay = Utility.GetNumberOfDay(holiday.StartDate, holiday.EndDate)
            })
                .ToList();
        } 
    }
}
