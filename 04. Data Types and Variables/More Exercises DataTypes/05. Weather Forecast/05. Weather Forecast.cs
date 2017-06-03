using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var number = long.Parse(Console.ReadLine());

                if (number >= sbyte.MinValue && number <= sbyte.MaxValue)
                {
                    Console.WriteLine("Sunny");
                }
                else if (number >= int.MinValue && number <= int.MaxValue)
                {
                    Console.WriteLine("Cloudy");
                }
                else
                {
                    Console.WriteLine("Windy");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Rainy");
            }
        }
    }
}
