using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(new[] { ',', ';', ':', '.', '!', '(', ')', '"',
                '\'', '\\', '/', '[', ']', ' ' },StringSplitOptions.RemoveEmptyEntries).ToArray();

            var lowerCaseWords = new List<string>();
            var upperCaseWords = new List<string>();
            var mixedCaseWords = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];
                var lowerCaseLetters = 0;
                var upperCaseLetters = 0;

                for (int j = 0; j < currentWord.Length; j++)
                {
                    if (currentWord[j] >= 65 && currentWord[j] <=90)
                    {
                        upperCaseLetters++;
                    }
                    else if (currentWord[j] >= 97 && currentWord[j] <= 122)
                    {
                        lowerCaseLetters++;
                    }
                }

                if (currentWord.Length == lowerCaseLetters)
                {
                    lowerCaseWords.Add(currentWord);
                }
                else if (currentWord.Length == upperCaseLetters)
                {
                    upperCaseWords.Add(currentWord);
                }
                else
                {
                    mixedCaseWords.Add(currentWord);
                }
            }
            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCaseWords));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCaseWords));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCaseWords));

        }
    }
}
