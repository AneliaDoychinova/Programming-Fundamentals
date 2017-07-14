using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _07.Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            var phrases = File.ReadAllLines("phrases.txt");
            var events = File.ReadAllLines("events.txt");
            var authors = File.ReadAllLines("authors.txt");
            var cities = File.ReadAllLines("cities.txt");
          
            var numbersOfMessages = int.Parse(File.ReadAllText("numbers.txt"));

            var rnd = new Random();

            for (int i = 0; i < numbersOfMessages; i++)
            {
                var phrase = rnd.Next(0, phrases.Length);
                var event1 = rnd.Next(0, events.Length);
                var author = rnd.Next(0, authors.Length);
                var city = rnd.Next(0, cities.Length);

                File.AppendAllText("output.txt",
                    phrases[phrase] + " " + events[event1] + " " + authors[author] + " - " + cities[city] + 
                    Environment.NewLine);

            }
   

        }

        static void TrimStrings(List<string> phrases)
        {
            for (int i = 0; i < phrases.Count; i++)
            {
                var currentPhrase = phrases[i];
                if (i == 0)
                {
                    phrases[i] = currentPhrase.Substring(1, currentPhrase.Length - 3);
                }
                else
                {
                    phrases[i] = currentPhrase.Substring(2, currentPhrase.Length - 3);
                }

            }
        }
    }
}
