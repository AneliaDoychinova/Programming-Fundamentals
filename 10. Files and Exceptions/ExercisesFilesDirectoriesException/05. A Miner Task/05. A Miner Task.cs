using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _05.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllLines("input.txt");

            var resources = new Dictionary<string, int>();
            for (int i = 0; i < input.Length; i+=2)
            {
                var resource = input[i];
                var quantity = int.Parse(input[i + 1]);

                if (!resources.ContainsKey(resource))
                {
                    resources[resource] = 0;
                }
                resources[resource] += quantity;
            }

            foreach (var resource in resources)
            {
                var name = resource.Key;
                var quantity = resource.Value;

                File.AppendAllText("output.txt", name + " -> " + quantity + Environment.NewLine);
            }
        }
    }
}
