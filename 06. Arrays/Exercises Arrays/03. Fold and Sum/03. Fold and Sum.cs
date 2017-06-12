using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            var k =numbers.Length/4;

            var upperLeftRow = new int[k];
            var upperRightRow = new int[k];
            var lowerRow = new int[2 * k];
            var sum = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
               upperLeftRow[i] = numbers[i];
               upperRightRow[i] = numbers[i + 3 * k];
            }
            Array.Reverse(upperLeftRow);
            Array.Reverse(upperRightRow);

            for (int i = 0; i < 2*k; i++)
            {
                lowerRow[i] = numbers[i+k];
            }

            for (int i = 0; i < sum.Length; i++)
            {
                if (i<sum.Length/2)
                {
                    sum[i] = lowerRow[i] + upperLeftRow[i];
                }
                else
                {
                    sum[i] = lowerRow[i] + upperRightRow[i - sum.Length / 2];
                }
                
            }
            Console.WriteLine(string.Join(" ", sum));
           

        }
    }
}
