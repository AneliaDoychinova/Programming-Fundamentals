using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var userIPDuration = new SortedDictionary<string, SortedDictionary<string, int>>(); //<user,IP,duration>

            for (int i = 0; i < n; i++)
			{
			    var input = Console.ReadLine().Split(' ');

                var user = input[1];
                var ipAdress = input[0];
                var duration = int.Parse(input[2]);

                if (!userIPDuration.ContainsKey(user))
	            {
		            userIPDuration[user] = new SortedDictionary<string,int>();
	            }
                if (!userIPDuration[user].ContainsKey(ipAdress))
                {
                    userIPDuration[user][ipAdress] = 0;
                }
                userIPDuration[user][ipAdress] += duration;
			}


            foreach (var user in userIPDuration)
            {
                var userName = user.Key;
                var ipAdressDuration = user.Value;
                var sumDuration = ipAdressDuration.Values.Sum();

                Console.WriteLine("{0}: {1} [{2}]", userName, sumDuration, string.Join(", ", ipAdressDuration.Keys));

            }
            
        }
    }
}
