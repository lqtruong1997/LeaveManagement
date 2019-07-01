using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagementSPA.ViewModels
{
    public class Utility
    {
        public static readonly List<string> Months = new List<string>() {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "July",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"
        };

        public static string DateToString(DateTime date)
        {
            string result = "";

            result = date.Day + "-" + Months[date.Month - 1] + "-" + date.Year;

            return result;
        }

        public static int GetNumberOfDay(DateTime start, DateTime end)
        {
            return (end - start).Days + 1;
        }
    }
}
