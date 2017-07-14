using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"\b(0x)*[0-9A-F]+\b";

            var hexadecimalNums = Console.ReadLine();

            MatchCollection matches = Regex.Matches(hexadecimalNums, pattern);

            foreach (Match num in matches)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
