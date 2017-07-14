using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03.Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordsCount = new Dictionary<string, int>();

            var words = File.ReadAllText("words.txt").ToLower().
                Split(new char[] {' ', '\n', '\r'}, StringSplitOptions.RemoveEmptyEntries).ToList();

            var input = File.ReadAllText("input.txt").ToLower().
                Split(new char [] {' ', '-', ',', '.', '?', '!', '\r', '\n'},
                StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (var word in words)
            {
                wordsCount[word] = 0;
            }

            foreach (var word in input)
            {
                if (wordsCount.ContainsKey(word))
                {
                    wordsCount[word]++;
                }
            }

            wordsCount = wordsCount.OrderByDescending(a => a.Value).ToDictionary(a => a.Key, a => a.Value);

            foreach (var kvp in wordsCount)
            {
                var word = kvp.Key;
                var count = kvp.Value;

                File.AppendAllText("output.txt", $"{word} - {count}" + Environment.NewLine);
            }




        }
    }
}
