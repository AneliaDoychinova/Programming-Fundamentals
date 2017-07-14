using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            var singers = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
            var songs = Console.ReadLine().Split(',').Select(a => a.Trim()).ToArray();

            var input = Console.ReadLine();
            var awards = new Dictionary<string, List<string>>();
            while (input != "dawn")
            {
                var tokens = input.Split(',');
                var singer = tokens[0].Trim();
                var song = tokens[1].Trim();
                var award = tokens[2].Trim();

                if (singers.Contains(singer) && songs.Contains(song))
                {
                    if (!awards.ContainsKey(singer))
                    {
                        awards[singer] = new List<string>();
                    }
                    if (!awards[singer].Contains(award))
                    {
                        awards[singer].Add(award);
                    }
                    
                }

                input = Console.ReadLine();
            }
            if (awards.Count == 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                var sortDict = awards.OrderByDescending(a => a.Value.Count).ThenBy(a => a.Key).ToList();

                foreach (var singer in sortDict)
                {
                    Console.WriteLine("{0}: {1} awards", singer.Key, singer.Value.Count);

                    foreach (var award in singer.Value.OrderBy(a => a))
                    {
                        Console.WriteLine("--{0}", award);
                    }

                }
            }

        }
    }
}
