using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = Console.ReadLine().Split().ToArray();

            //var reversedString = strings.Reverse();
            var last = strings.Length-1;
            for (int i = 0; i < strings.Length/2; i++)
            {
                var temp = strings[i];
                strings[i] = strings[last];
                strings[last] = temp;
                last--;
            }
            Console.WriteLine(string.Join(" ", strings));
        }
    }
}
