using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Models
{
    public class HolidayDataAccessLayer
    {
        private readonly TestDBContext _db = new TestDBContext();

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
