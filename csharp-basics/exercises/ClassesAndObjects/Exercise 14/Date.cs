using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_14
{
    public class Date
    {
        public static string WeekdayInDutch(int year, int month, int day)
        {
            DateTime date = new DateTime(year, month, day);
            CultureInfo culture = CultureInfo.GetCultureInfo("nl-NL");
            return culture.DateTimeFormat.DayNames[(int)date.DayOfWeek];
        }
    }
}