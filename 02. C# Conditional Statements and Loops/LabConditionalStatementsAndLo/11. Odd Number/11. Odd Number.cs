using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            
            

            while (number % 2 == 0)
            {
                Console.WriteLine("Please write an odd number.");
                number = double.Parse(Console.ReadLine());
            }

            number = Math.Abs(number);
            Console.WriteLine("The number is: {0}", number);
        }
    }
}
