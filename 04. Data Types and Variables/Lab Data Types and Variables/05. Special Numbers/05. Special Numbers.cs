using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
           
            
            

            for (int i = 1; i <= n; i++)
            {
                var isSum = false;
                var sumOfDigits = 0;
                var num = i;
                while (num != 0)
                {
                    sumOfDigits += (num % 10);
                    num = num / 10;
                }
                if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
                {
                    isSum = true;
                }

                Console.WriteLine("{0} -> {1}", i, isSum);
            }
        }
    }
}
