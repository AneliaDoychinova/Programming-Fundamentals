using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().ToLower().Split(' ').ToArray();

            var numberOfOccurance = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];

                if (!numberOfOccurance.ContainsKey(currentWord))
                {
                    numberOfOccurance.Add(currentWord, 0);
                }

                numberOfOccurance[currentWord]++;
            }
            var oddOccurances = new List<string>();

            foreach (var kvp in numberOfOccurance)
            {
                if (kvp.Value % 2 == 1)
                {
                    oddOccurances.Add(kvp.Key);
                }
            }
            Console.WriteLine(string.Join(", ", oddOccurances));
        }
    }
}
