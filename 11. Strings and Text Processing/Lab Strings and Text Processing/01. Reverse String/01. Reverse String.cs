using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine();
            var reversed = new string(inputString.Reverse().ToArray());
            Console.WriteLine(reversed);
        }
    }
}
