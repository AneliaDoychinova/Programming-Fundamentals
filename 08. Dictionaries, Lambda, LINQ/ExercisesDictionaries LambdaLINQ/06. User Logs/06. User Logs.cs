using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');

            var userLogs = new SortedDictionary<string, Dictionary<string,int>>();

            while (input[0] != "end")
            {
                var userName = input[2].Remove(0, 5);
                var ipAdress = input[0].Remove(0, 3);

                if (!userLogs.ContainsKey(userName))
                {
                    userLogs[userName] = new Dictionary<string, int>();
                    userLogs[userName][ipAdress] = 1;
                }
                else
                {
                    if (!userLogs[userName].ContainsKey(ipAdress))
	                {
                        userLogs[userName][ipAdress] = 1;
	                }
                    else
                    {
                        userLogs[userName][ipAdress]++;
                    }
                    
                }
                input = Console.ReadLine().Split(' ');
            }

            foreach (var user in userLogs)
            {
                var userName = user.Key;

                Console.WriteLine("{0}: ",userName);
                var ipCount = 0;

                foreach (var logs in user.Value)
                {
                    var ip = logs.Key;
                    var count = logs.Value;
                    
                    Console.Write("{0} => {1}{2}", ip,count, (ipCount == userLogs[userName].Count-1) ? ".":", ");
                    ipCount++;
                }
                Console.WriteLine();
            }

        }
    }
}
