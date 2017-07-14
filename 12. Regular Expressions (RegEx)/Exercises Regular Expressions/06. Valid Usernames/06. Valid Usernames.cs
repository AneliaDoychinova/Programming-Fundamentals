using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var usernames = Console.ReadLine()
                .Split(new char[] { ' ', '/', '\\', '(', ')' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var regex = @"^[a-zA-Z]{1}[\w]{2,22}$";

            var matchesUsernames = new List<string>();

            foreach (var username in usernames)
            {
                Match match = Regex.Match(username, regex);
                if (match.Success)
                {
                    matchesUsernames.Add(match.ToString());
                }
            }

            var firstWord = string.Empty;
            var secondWord = string.Empty;
            var lenght = 0;

            for (int i = 0; i < matchesUsernames.Count - 1; i++)
            {
                var word1 = matchesUsernames[i];
                var word2 = matchesUsernames[i+1];

                if (word1.Length+word2.Length > lenght)
                {
                    lenght = word1.Length + word2.Length;
                    firstWord = word1;
                    secondWord = word2;
                }
            }
            Console.WriteLine(firstWord);
            Console.WriteLine(secondWord);
            
        }
    }
}
