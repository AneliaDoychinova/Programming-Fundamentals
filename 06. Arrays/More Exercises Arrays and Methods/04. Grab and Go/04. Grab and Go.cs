using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grab_and_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var numToSearch = int.Parse(Console.ReadLine());

            Array.Reverse(numbers);
            var sum = 0L;
            var isFound = false;

            for (int i = 0; i < numbers.Length; i++)
            {   
                
                if (isFound)
                {
                    sum += numbers[i];
                }

                if (numbers[i] == numToSearch)
                {
                    isFound = true;
                }
                
            }
            if (isFound)
            {
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }
    }
}
