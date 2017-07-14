using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToLower();
            var searchString = Console.ReadLine().ToLower();

            var index = text.IndexOf(searchString, 0);
            var count = 0;

            while (index != -1)
            {
                count++;
                index = text.IndexOf(searchString, index + 1);
            }

            Console.WriteLine(count);
        }
    }
}
