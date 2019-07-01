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
    public class LeaveDashboardController : ControllerBase
    {
        private readonly UserRepository _user = new UserRepository();
        private readonly HolidayRepository _holiday = new HolidayRepository();

        [HttpGet]
        [Route("GetUpcomingHoliday")]
        public IEnumerable<HolidayViewModels> GetUpcomingHoliday(int numberOfHoliday)
        {
            var holidays = _holiday.GetUpcomingHoliday(numberOfHoliday);

            return holidays.Select(holiday => new HolidayViewModels(holiday)).ToList();
        }

        [HttpGet]
        [Route("GetUserById")]
        public Users GetUserById(string id)
        {
            return _user.GetUserById(id);
        }
    }
}