using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            var reversedNums = new int[n];
            var count = 0;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                reversedNums[count] = numbers[i];

                count++;
            }

            Console.WriteLine(string.Join(" ", reversedNums));
        }
    }
}
