using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var resources = new Dictionary<string, int>();

            var input = Console.ReadLine();

            while (input != "stop")
            {
                var resource = input;

                if (!resources.ContainsKey(resource))
                {
                    resources[resource] = 0;
                }

                resources[resource] += int.Parse(Console.ReadLine());
                input = Console.ReadLine();
            }

            foreach (var kvp in resources)
            {
                Console.WriteLine("{0} -> {1}",kvp.Key,kvp.Value);
            }
        }
    }
}
