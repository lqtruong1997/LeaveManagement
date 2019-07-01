using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeaveManagementSPA.Models;

namespace LeaveManagementSPA.Repositories
{
    public class HolidayRepository
    {
        private readonly LeaveManagementDBContext _db = new LeaveManagementDBContext();

        public IEnumerable<Holiday> GetUpcomingHoliday(int numberOfHoliday)
        {
            try
            {
                var today = DateTime.Today;

                var upcomingHolidays = _db.Holiday.Where(t => t.StartDate > today);

                return upcomingHolidays.OrderBy(
                        d => d.StartDate - today
                    )
                    .Take(numberOfHoliday);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            } 
        }
    }
}
