using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Censorship
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var sentense = Console.ReadLine();

            var replacedSentence = Regex.Replace(sentense, word, new string('*', word.Length));

            Console.WriteLine(replacedSentence);
        }
    }
}
