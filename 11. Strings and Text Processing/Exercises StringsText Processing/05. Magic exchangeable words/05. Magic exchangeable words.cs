using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Magic_exchangeable_words
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
            var firstWord = words[0];
            var secondWord = words[1];

            bool result = AreExchangeable(firstWord, secondWord);
            Console.WriteLine(result.ToString().ToLower());

        }

        static bool AreExchangeable(string firstWord, string secondWord)
        {
            var shorterStr = string.Empty;
            var longerStr = string.Empty;

            if (firstWord.Length > secondWord.Length)
            {
                longerStr = firstWord;
                shorterStr = secondWord;
            }
            else
            {
                longerStr = secondWord;
                shorterStr = firstWord;
            }

            var mappings = new Dictionary<char,char>();
            bool isExchangeabale = true;

            for (int i = 0; i < shorterStr.Length; i++)
            {
                if (!mappings.ContainsKey(firstWord[i]) && !mappings.ContainsValue(secondWord[i]))
                {
                    mappings[firstWord[i]] = secondWord[i];
                }
                else
                {
                    if (mappings.ContainsKey(firstWord[i]))
                    {
                        if (mappings[firstWord[i]] != secondWord[i])
                        {
                            isExchangeabale = false;
                            return isExchangeabale;
                        }
                    }
                    else if (mappings.ContainsValue(secondWord[i]))
                    {
                        isExchangeabale = false;
                        return isExchangeabale;
                    }
                }
            }

            string remainingLetters = longerStr.Substring(shorterStr.Length);

            foreach (char letter in remainingLetters)
            {
                if (!mappings.ContainsKey(letter) && !mappings.ContainsValue(letter))
                {
                    isExchangeabale = false;
                    return isExchangeabale;
                }
            }

            return isExchangeabale;
        }
    }
}
