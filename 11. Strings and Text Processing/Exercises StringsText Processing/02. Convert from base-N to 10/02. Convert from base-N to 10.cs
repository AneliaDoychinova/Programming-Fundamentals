using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.Convert_from_base_N_to_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
            var currentBase = numbers[0];
            var num = numbers[1];
            var resultNum = new BigInteger();
            var i = 0;

            while(num != 0)
            {
                var lastDigit = (num % 10);
                resultNum += lastDigit * BigInteger.Pow(currentBase, i);
                num = num / 10;
                i++;
            }
            Console.WriteLine(resultNum);
        }
    }
}
