using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Comparing_floats
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = double.Parse(Console.ReadLine());
            var number2 = double.Parse(Console.ReadLine());

            var eps = 0.000001;
            var difference = Math.Abs(number1 - number2);
            if (difference>=eps)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }

        }
    }
}
