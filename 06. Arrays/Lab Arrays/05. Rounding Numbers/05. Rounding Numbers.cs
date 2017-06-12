using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var roundedNumbers = new double [numbers.Length];
            
            for (int i = 0; i < numbers.Length; i++)
            {
                roundedNumbers[i] = Math.Round(numbers[i], 0, MidpointRounding.AwayFromZero);

                Console.WriteLine("{0} => {1}", numbers[i], roundedNumbers[i]);
            }

        }
    }
}
