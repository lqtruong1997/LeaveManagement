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
    public class LeaveDashboardController : ControllerBase
    {
        //private readonly HolidayDataAccessLayer _holiday = new HolidayDataAccessLayer();
        private readonly UserDataAccessLayer _user = new UserDataAccessLayer();
        private readonly HolidayDTOService _holidayDto = new HolidayDTOService(); 

        [HttpGet]
        [Route("GetUpcomingHoliday")]
        public IEnumerable<HolidayDTO> GetUpcomingHoliday(int numberOfHoliday)
        {
            return _holidayDto.GetUpcomingHoliday(numberOfHoliday);
        }

        [HttpGet]
        [Route("GetUserById")]
        public Users GetUserById(string id)
        {
            return _user.GetUserById(id);
        }
    }
}