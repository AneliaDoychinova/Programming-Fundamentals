using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
    {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());

            var numbers = new long[n];
            numbers[0] = 1;

            for (int i = 1; i < n; i++)
            {
                int start = Math.Max(0, i - k);
                int end = i - 1;

                long sum = 0L;

                for (int j = start; j <= end; j++)
                {
                    sum += numbers[j]; 
                }
                numbers[i] = sum;
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
