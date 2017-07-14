using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyString = Console.ReadLine();
            var text = Console.ReadLine();

            var startKeyRegex = @"^[A-Za-z]+(?=<|\||\\)";
            var startKey = Regex.Match(keyString, startKeyRegex).Value;

            var endKeyRegex = @"(?<=\\|\||<)[A-Za-z]+$";
            var endKey = Regex.Match(keyString, endKeyRegex).Value;

            var pattern = @"(?<="+startKey+@").*?(?="+endKey+")";
            MatchCollection matches = Regex.Matches(text, pattern);
            var isMatch = false;
            if (matches.Count == 0 || startKey == string.Empty || endKey == string.Empty)
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                foreach (Match match in matches)
                {
                    if (match.Length > 0)
                    {
                        isMatch = true;
                        Console.Write(match);
                    }
                }
                if (isMatch)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Empty result");
                }
                
            }
        }
    }
}
