using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"\s*\+359([- ])2\1\d{3}\1\d{4}\b";

            var phones = Console.ReadLine();

            MatchCollection matches = Regex.Matches(phones, regex);

            var matchedPhones = matches
            .Cast<Match>()
            .Select(a => a.Value.Trim())
            .ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
