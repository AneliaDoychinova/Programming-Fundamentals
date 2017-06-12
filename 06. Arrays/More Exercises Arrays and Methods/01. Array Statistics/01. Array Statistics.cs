using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Array_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var min = numbers.Min();
            var max = numbers.Max();
            var sum = numbers.Sum();
            var avg = numbers.Average();

            Console.WriteLine("Min = {0}",min);
            Console.WriteLine("Max = {0}", max);
            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("Average = {0}", avg);

        }
    }
}
