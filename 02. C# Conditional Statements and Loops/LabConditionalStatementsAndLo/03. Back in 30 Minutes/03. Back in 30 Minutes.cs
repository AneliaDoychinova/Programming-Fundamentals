using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            var totalMinutes = hours * 60 + minutes;
            var minutesPlus30 = totalMinutes + 30;

            var resultHours = minutesPlus30 / 60;
            if (resultHours == 24)
            {
                resultHours = 0;
            }
            var resultMinutes = minutesPlus30 % 60;

            Console.WriteLine("{0}:{1:D2}", resultHours, resultMinutes);
        }
    }
}
