using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var startIndex = 0;
            var len = 1;
            var maxLen = 1;
            var bestStartIndex = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    len++;

                    if (maxLen < len)
                    {
                        maxLen = len;
                        bestStartIndex = startIndex;
                    }
                }
                else
                {
                    len = 1;
                    startIndex = i; ;
                }
            }

            for (int i = bestStartIndex; i < bestStartIndex + maxLen; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

        }
    }
}
