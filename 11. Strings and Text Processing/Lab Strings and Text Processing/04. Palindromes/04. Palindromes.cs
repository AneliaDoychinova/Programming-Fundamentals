using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(new char[] { '.', ' ', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var palindromes = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];
                var reversedWord =new string(words[i].Reverse().ToArray());

                if (currentWord.CompareTo(reversedWord) == 0)
                {
                    palindromes.Add(currentWord);
                }
            }

            var sortedPalindromes = palindromes.Distinct().OrderBy(x => x).ToList();

            Console.WriteLine(string.Join(", ", sortedPalindromes));
        }
    }
}
