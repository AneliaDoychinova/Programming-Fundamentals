using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
          
            if (numbers.Length == 1)
            {
                PrintArray(numbers);
            }
            else if (numbers.Length % 2 == 0)
            {
                var middleNums = new int[2];
                middleNums[0] = numbers[numbers.Length / 2 - 1];
                middleNums[1] = numbers[numbers.Length / 2];

                PrintArray(middleNums);
            }
            else if (numbers.Length % 2 == 1)
            {
                var middleNums = new int[3];
                middleNums[0] = numbers[numbers.Length / 2 - 1];
                middleNums[1] = numbers[numbers.Length / 2];
                middleNums[2] = numbers[numbers.Length / 2 + 1];

                PrintArray(middleNums);
            }
        }

        static void PrintArray(int[] numbers)
        {
            Console.WriteLine("{{ {0} }}", string.Join(", ", numbers));
        }
    }
}
