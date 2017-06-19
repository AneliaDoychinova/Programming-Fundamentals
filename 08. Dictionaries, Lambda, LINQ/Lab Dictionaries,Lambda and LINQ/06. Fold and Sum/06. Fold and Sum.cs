using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var k = numbers.Length / 4;

            var upperRowleftPart = numbers.Take(k).Reverse();
            var upperRowrightPart = numbers.Reverse().Take(k);
            var upperRow = upperRowleftPart.Concat(upperRowrightPart).ToArray();
            var lowerRow = numbers.Skip(k).Take(2 * k).ToArray();

            var sum = new int[lowerRow.Length];

            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = upperRow[i] + lowerRow[i];
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
