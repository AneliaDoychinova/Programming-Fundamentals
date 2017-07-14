using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"(^|(?<=\s))-?\d+(.\d+)*($|(?=\s))";

            var digits = Console.ReadLine();

            MatchCollection matches = Regex.Matches(digits, pattern);

            foreach (Match digit in matches)
            {
                Console.Write(digit + " ");
            }
            Console.WriteLine();
        }
    }
}
