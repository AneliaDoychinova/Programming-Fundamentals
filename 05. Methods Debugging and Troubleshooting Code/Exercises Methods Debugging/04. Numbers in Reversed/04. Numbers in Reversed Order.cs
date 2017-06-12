using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Numbers_in_Reversed
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());

            PrintReversedNumber(number);
        }

        static void PrintReversedNumber(double number)
        {
            var stringNum = number.ToString().ToArray();

            var reversedNum = stringNum.Reverse();

            Console.WriteLine(string.Join("", reversedNum));
        }
    }
}
