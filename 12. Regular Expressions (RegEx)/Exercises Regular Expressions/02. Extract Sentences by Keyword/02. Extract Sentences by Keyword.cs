using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyWord = Console.ReadLine();
            var text = Console.ReadLine()
                .Split(new char[] { '!', '?', '.' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var regex = @"\S.*\b" + keyWord + @"\b\s.*";

            foreach (var item in text)
            {
                Match match = Regex.Match(item,regex);
                if (match.Success)
                {
                    Console.WriteLine(match);
                }
                
            }
        }
    }
}
