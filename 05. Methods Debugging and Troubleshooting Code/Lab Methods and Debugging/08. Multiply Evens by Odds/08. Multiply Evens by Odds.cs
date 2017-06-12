using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);

            var result = MultiplyEvenByOdds(number);

            Console.WriteLine(result);
        }

        static int MultiplyEvenByOdds(int number)
        {
            var sumEvens = SumOfEvenDigits(number);
            var sumOdds = SumOfOddDigits(number);

            return sumEvens * sumOdds;
        }

        static int SumOfEvenDigits(int number)
        {
            var sum = 0;

            while (number>0)
            {
                var lastDigit = number % 10;

                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                number = number / 10;
            }
            return sum;
        }

        static int SumOfOddDigits(int number)
        {
            var sum = 0;

            while (number > 0)
            {
                var lastDigit = number % 10;

                if (lastDigit % 2 == 1)
                {
                    sum += lastDigit;
                }
                number = number / 10;
            }
            return sum;
        }
    }
}
