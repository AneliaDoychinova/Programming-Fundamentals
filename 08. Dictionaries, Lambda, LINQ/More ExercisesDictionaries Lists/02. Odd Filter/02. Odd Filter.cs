using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var evenNumbers = numbers.Where(e => e%2 == 0).ToList();
            var average = evenNumbers.Average();

            var result = evenNumbers.Select(k => k > average? k + 1 : k -1).ToList();
           
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
