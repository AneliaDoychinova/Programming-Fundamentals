using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var maxSum = int.Parse(Console.ReadLine());

            var totalCombinations = 0;
            var sum = 0;
            var isMaxSum = false;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    var product = i * j * 3;
                    sum += product;
                    totalCombinations++;
                    if (sum >= maxSum)
                    {
                        Console.WriteLine("{0} combinations",totalCombinations);
                        Console.WriteLine("Sum: {0} >= {1}", sum, maxSum);
                        isMaxSum = true;
                        break;
                    }
                }
                if (isMaxSum)
                {
                    break;
                }
            }
            if (!isMaxSum)
            {
                Console.WriteLine("{0} combinations", totalCombinations);
                Console.WriteLine("Sum: {0}", sum);
            }
            


        }
    }
}
