using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ').ToList();
            
            var randomGenerator = new Random();
            for (int i = 0; i < words.Count; i++)
            {
                var randomNum = randomGenerator.Next(0, words.Count - 1);
                var temp = words[i];
                words[i] = words[randomNum];
                words[randomNum] = temp;
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
