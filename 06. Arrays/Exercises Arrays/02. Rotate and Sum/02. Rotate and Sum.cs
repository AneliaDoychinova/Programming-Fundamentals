using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var k = int.Parse(Console.ReadLine());

            var sumNumbers = new int[numbers.Length];
            
            for (int i = 0; i < k; i++)
			{
                var rotatedNumbers = new int[numbers.Length];

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (j == 0)
                    {
                        rotatedNumbers[j] = numbers[numbers.Length - 1];
                    }
                    else
                    {
                        rotatedNumbers[j] = numbers[j - 1];
                    }
                }

                numbers = rotatedNumbers;

                for (int l = 0; l < numbers.Length; l++)
                {
                    sumNumbers[l] += numbers[l];
                }
                
			}
            Console.WriteLine(string.Join(" ", sumNumbers));
        }
    }
}
