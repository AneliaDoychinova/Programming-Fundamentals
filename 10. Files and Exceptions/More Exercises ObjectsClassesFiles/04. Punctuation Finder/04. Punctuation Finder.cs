using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _04.Punctuation_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllText("sample_text.txt").ToCharArray();

            var chars = new char[] {'.', ',', '!', '?', ':' };
            var punctuations = new List<char>();

            for (int i = 0; i < text.Length; i++)
            {
                if (chars.Contains(text[i]))
                {
                    punctuations.Add(text[i]);
                }
              
            }
           Console.WriteLine(string.Join(", ", punctuations));
        }
    }
}
