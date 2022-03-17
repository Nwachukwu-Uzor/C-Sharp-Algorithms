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
            var dayOfTheWeek = new[] { 
                "Monday", "Tuesday", "Wednesday",
                "Thursday", "Friday", "Saturday",
                "Sunday"
            };
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
