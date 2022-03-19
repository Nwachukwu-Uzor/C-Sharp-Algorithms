using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Globalization;

namespace C_Sharp.Core
{
    public class MostFrequentDay
    {
        public static string[] MostFrequentDays(int year)
        {
            var dayOfTheWeek = new string[] { 
                "Monday", "Tuesday", "Wednesday",
                "Thursday", "Friday", "Saturday",
                "Sunday"
            };

            // Get the number of days in a year
            var numOfDays = DateTime.IsLeapYear(year) ? 366 : 365;

            // Get the first and last days of the year
            var firstLastDay = GetFirstDay(year);
            var first = firstLastDay.FirstDay;
            var last = firstLastDay.LastDay;

            // Get Number of day to subtract due to first day
            var firstDayDifference = 7 - Array.IndexOf(dayOfTheWeek, firstLastDay.FirstDay);
            if (first == "Monday")
            {
                firstDayDifference = 0;
            }
            // Get Number of day to subtract due to first day
            var lastDayDifference = Array.IndexOf(dayOfTheWeek, firstLastDay.FirstDay) + 1;

            if (last == "Sunday")
            {
                lastDayDifference = 0;
            }

            // Get Number of full weeks
            decimal numberOfFullWeeks = (numOfDays - firstDayDifference - lastDayDifference) / 7m;

            Console.WriteLine(numberOfFullWeeks);

            // Get the number of fullweeks in the year

            return new string[0];
        }

        public static FirstDayLastDay GetFirstDay(int year)
        {
            var firstday = new DateTime(year, 1, 1, new GregorianCalendar());
            var lastday = new DateTime(year, 12, 31, new GregorianCalendar());


            return new FirstDayLastDay
            {
                FirstDay = firstday.DayOfWeek.ToString(), 
                LastDay = lastday.DayOfWeek.ToString()
            };
        }
    }

    public class FirstDayLastDay {
        public string FirstDay { get; set; }
        public string LastDay { get; set; }
    }
}
