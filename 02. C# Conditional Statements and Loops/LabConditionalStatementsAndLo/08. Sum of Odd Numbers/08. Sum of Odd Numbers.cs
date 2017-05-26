using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var sum = 0;
            var count = 0;

            for (int i = 1; ; i++)
            {
                if (count == number)
                {
                    break;
                }
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                    sum += i;
                    count++;
                }
            }
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
