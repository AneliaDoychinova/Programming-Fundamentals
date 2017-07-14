using System;
using System.Linq;
using System.Globalization;

namespace _01.Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            var startDateFormat = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var endDateFormat = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
          
            var holidays = new []
            { 
               "01 01",
               "03 03",
               "01 05",
               "06 05",
               "24 05",
               "06 09",
               "22 09",
               "01 11",
               "24 12",
               "25 12",
               "26 12"
            }.Select(d => DateTime.ParseExact(d, "dd MM", CultureInfo.InvariantCulture)).ToArray();

            var workingDayCounter = 0;

            for (DateTime currentDate = startDateFormat; currentDate <= endDateFormat; currentDate = currentDate.AddDays(1))
            {
                var isSaturdayOrSunday = currentDate.DayOfWeek == DayOfWeek.Saturday || currentDate.DayOfWeek == DayOfWeek.Sunday;
                var isHoliday = holidays.Any(d => d.Day == currentDate.Day && d.Month == currentDate.Month);
                var isWorkingDay = !(isHoliday || isSaturdayOrSunday);
                
                if (isWorkingDay)
	            {
		            workingDayCounter++;
	            }
            }

            Console.WriteLine(workingDayCounter);

        }

    }
}
