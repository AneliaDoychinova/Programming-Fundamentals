using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.X
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var rows = n;
            var columns = n;

            var middleIntervals = n - 2;
            var leftIntervals = 0;

            //UpperPart
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}x{1}x", new string(' ',leftIntervals), new string(' ', middleIntervals));
                middleIntervals-=2;
                leftIntervals++;
            }
            //MiddleRow
            Console.WriteLine("{0}x", new string(' ', leftIntervals));

            //LowerPart
            leftIntervals--;
            middleIntervals = 1;

            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}x{1}x", new string(' ',leftIntervals), new string(' ', middleIntervals));
                leftIntervals--;
                middleIntervals += 2;
            }

        }
    }
}
