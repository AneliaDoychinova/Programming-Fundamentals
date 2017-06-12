using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14.Factorial_Trailing_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var factorialNum = GetFactorialNum(n);
            var zeroesCount = CutTheTrailingZeroes(factorialNum);

            Console.WriteLine(zeroesCount);
        }

        static int CutTheTrailingZeroes(BigInteger factorialNum)
        {
            var count = 0;
            int lastDigit;

            do
            {
                lastDigit = (int)(factorialNum % 10);
                factorialNum = factorialNum / 10;
                if (lastDigit == 0)
                {
                    count++;
                }
            }
            while (lastDigit == 0);
            return count;
        }

        static BigInteger GetFactorialNum(int n)
        {
            BigInteger factorial = 1;
            for (long i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
