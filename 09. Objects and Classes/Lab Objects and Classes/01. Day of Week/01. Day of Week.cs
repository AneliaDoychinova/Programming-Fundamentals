using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringDate = Console.ReadLine();

            var dateFormat = DateTime.ParseExact(stringDate, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(dateFormat.DayOfWeek);
        }
    }
}
