using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"([^\d]*)(\d+)");
            var input = Console.ReadLine();
            MatchCollection matches = regex.Matches(input);

            var sb = new StringBuilder();

            foreach (Match match in matches)
            {
                var stringToRepeat = match.Groups[1].Value;
                var count = int.Parse(match.Groups[2].Value);

                for (int i = 0; i < count; i++)
                {
                    sb.Append(stringToRepeat.ToUpper());
                }
            }


            var uniqueSymbolsNum = sb.ToString().ToArray().Distinct().Count();
            Console.WriteLine("Unique symbols used: {0}", uniqueSymbolsNum);
            Console.WriteLine(sb.ToString());
        }
    }
}
