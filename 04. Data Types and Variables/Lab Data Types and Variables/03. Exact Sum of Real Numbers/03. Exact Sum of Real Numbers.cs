using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var sum = 0m;

            for (int i = 0; i < n; i++)
            {
                var number = decimal.Parse(Console.ReadLine());

                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}
