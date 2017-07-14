using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var listOfEvents = new Dictionary<int, Event>();
            while (input != "Time for Code")
            {
                var tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var id = int.Parse(tokens[0]);
                var name = tokens[1].Substring(1);

                if (tokens[1][0] != '#')
                {
                    input = Console.ReadLine();
                    continue;
                }
                var participants = new HashSet<string>();
                for (int i = 2; i < tokens.Length; i++)
                {
                    if (tokens[i][0] != '@')
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    participants.Add(tokens[i]);
                }



                if (!listOfEvents.ContainsKey(id))
                {
                    listOfEvents[id] = new Event() { ID = id, Name = name, Participants = participants };
                }
                else
                {
                    if (listOfEvents[id].Name == name)
                    {
                        for (int i = 2; i < tokens.Length; i++)
                        {
                            listOfEvents[id].Participants.Add(tokens[i]);
                        }
                    }
                }

                input = Console.ReadLine();
            }
            var sortedList = listOfEvents.OrderByDescending(a => a.Value.Participants.Count).ThenBy(n => n.Value.Name).ToList();
            
            foreach (var events in sortedList)
            {
                Console.WriteLine("{0} - {1}", events.Value.Name, events.Value.Participants.Count);

                foreach (var participant in events.Value.Participants.OrderBy(n => n))
                {
                    Console.WriteLine(participant);
                }
            }
        }

        class Event
        {
            public int ID { get; set; }

            public string Name { get; set; }

            public HashSet<string> Participants { get; set; }
        }
    }
}
