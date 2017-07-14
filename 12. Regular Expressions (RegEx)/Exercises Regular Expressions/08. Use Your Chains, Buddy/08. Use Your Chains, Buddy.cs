using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.Use_Your_Chains__Buddy
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var pattern = new Regex(@"<p>(?<message>.+?)<\/p>");

            var paragraphs = pattern.Matches(text)
                .Cast<Match>()
                .Select(a => a.Groups["message"].Value)
                .Select(a => Regex.Replace(a, @"[^a-z\d]", " "))
                .Select(a => Regex.Replace(a, @"\s+", " "))
                .ToArray();

            for (int i = 0; i < paragraphs.Length; i++)
            {
                paragraphs[i] = Rot13(paragraphs[i]);
            }

            var result = new StringBuilder();

            foreach (var paragraph in paragraphs)
            {
                result.Append(paragraph);
            }

            Console.WriteLine(result.ToString());
        }

        private static string Rot13(string p)
        {
            var result = new StringBuilder();

            foreach (char letter in p)
            {
                result.Append(Rot13(letter));
            }

            return result.ToString();
        }

        private static char Rot13(char letter)
        {
            if (!char.IsLetter(letter))
            {
                return letter;
            }

            var offset = char.IsUpper(letter) ? 'A' : 'a';
            char rotatedLetter = (char)((letter - offset + 13) % 26 + offset);
            return rotatedLetter;
        }
    }
}
