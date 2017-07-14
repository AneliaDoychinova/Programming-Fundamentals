using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"(?<=\s)[a-z0-9]+([.\-_]\w*)*@[a-z]+([.\-_]\w*)*(\.[a-z]+)";

            var text = Console.ReadLine();

            MatchCollection extractedEmails = Regex.Matches(text,pattern);

            foreach (Match email in extractedEmails)
            {
                Console.WriteLine(email);
            }
        }
    }
}
