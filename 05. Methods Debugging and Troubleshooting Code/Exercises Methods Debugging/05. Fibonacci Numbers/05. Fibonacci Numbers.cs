using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var nthNum = CalcNthFibonacciNum(number);

            Console.WriteLine(nthNum);
        }

        static int CalcNthFibonacciNum(int number)
        {
            var count = 0;
            var lastNum = 0;
            var currentNum = 1;
            var nextNum = 1;

            if (number == 0)
            {
                return 1;
            }
            while(true)
            {
                nextNum = currentNum + lastNum;
                count++;
                if (count == number)
                {
                    return nextNum;
                }
                lastNum = currentNum;
                currentNum = nextNum;


            }
        }
    }
}
