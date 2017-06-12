using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Day_of_week
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayDaysName = new string[7] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

            var num = int.Parse(Console.ReadLine());

            if (num >= 1 && num <= 7)
            {
                Console.WriteLine(arrayDaysName[num-1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }

        }
    }
}
