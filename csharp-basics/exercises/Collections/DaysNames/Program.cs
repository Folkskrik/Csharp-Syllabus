using System;
using System.Globalization;
using System.Linq;

var dayNames = CultureInfo.CurrentCulture.DateTimeFormat.DayNames;
var query = dayNames.Select(dayName => dayName);

foreach (var dayName in query)
{
    Console.WriteLine(dayName);
}
