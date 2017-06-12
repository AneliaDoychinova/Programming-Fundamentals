using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                var isSimetric = GetIsSimetric(i);
                var isSumOfDigits = IsSumOfDigitsDivisibleBySeven(i);
                var isEvenDigit = IsHoldsAtLeastOneEvenDigit(i);

                if (isSimetric && isSumOfDigits && isEvenDigit)
                {
                  Console.WriteLine(i);  
                }
            }
        }

        static bool IsHoldsAtLeastOneEvenDigit(int number)
        {
            var digit = 0;
            while (number > 0)
            {
                digit = number % 10;

                if (digit % 2 == 0)
                {
                    return true;
                }
                number = number / 10;
            }
            return false;
        }

        static bool IsSumOfDigitsDivisibleBySeven(int number)
        {
            var sumOfDigit = 0;

            while (number > 0)
            {
                sumOfDigit += number % 10;
                number = number / 10;
            }

            if (sumOfDigit % 7 == 0)
            {
                return true;
            }
            return false;
        }

        static bool GetIsSimetric(int number)
        {
            int left = number;
            int rev = 0;
            while (left > 0)
            {
               var lastDigit = left % 10;
                rev = rev * 10 + lastDigit;
                left = left / 10;
            }
            if (rev == number)
            {
                return true;
            }
            return false;
        }
    }
}
