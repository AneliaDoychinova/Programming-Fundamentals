using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _10.Сръбско_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(.*?) @(.*?) (\d+) (\d+)";

            var singerDict = new Dictionary<string, Dictionary<string, int>>(); //venue, singer, totalMoney
            string input = Console.ReadLine();

            while (input != "End")
            {
                /// Chech if input matches pattern
                if (!Regex.IsMatch(input, pattern))
                {
                    input = Console.ReadLine();
                    continue;
                }

                /// Split input
                string[] inputArr = input.Split("@".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
                string singerName = inputArr[0].Trim();
                string[] concertInfo = inputArr[1].Trim().Split().ToArray();
                int ticketPrice = int.Parse(concertInfo[concertInfo.Length - 2]);
                int ticketCount = int.Parse(concertInfo[concertInfo.Length - 1]);
                int totalMoney = ticketCount * ticketPrice;

                string venue = string.Empty;
                for (int i = 0; i < concertInfo.Length - 2; i++)
                {
                    venue += " " + concertInfo[i];
                }

                venue = venue.Trim();
                // Fill the Dict
                if (!singerDict.ContainsKey(venue))
                {
                    singerDict[venue] = new Dictionary<string, int>();
                }
                if (!singerDict[venue].ContainsKey(singerName))
                {
                    singerDict[venue][singerName] = 0;
                }

                singerDict[venue][singerName] += totalMoney;

                input = Console.ReadLine();
            }

            foreach (var kvp in singerDict)
            {
                var vanue = kvp.Key;
                var singerMoney = kvp.Value;
                var orderedDict = singerMoney.OrderByDescending(m => m.Value);
                
                Console.WriteLine(vanue);

                foreach (var pairs in orderedDict)
                {
                    var singerName = pairs.Key;
                    var totalMoney = pairs.Value;

                    Console.WriteLine("#  {0} -> {1}",singerName, totalMoney);
                }
            }
        }
    }
}
