using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z]{1}[a-z]{2})\1(?<year>\d{4})\b";

            var dates = Console.ReadLine();

            MatchCollection matches = Regex.Matches(dates, pattern);

            foreach (Match date in matches)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine("Day: {0}, Month: {1}, Year: {2}",day,month,year);
            }
        }
    }
}
