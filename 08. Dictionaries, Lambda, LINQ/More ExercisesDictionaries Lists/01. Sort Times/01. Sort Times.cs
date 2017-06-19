using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sort_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            var times = Console.ReadLine().Split(' ').Select(DateTime.Parse).ToList();
            
            var format = "HH:mm";
            var sortedTimes = times.OrderBy(k => k).Select(k => k.ToString(format));
            
            Console.WriteLine(string.Join(", ",sortedTimes));

        }

    }
}
