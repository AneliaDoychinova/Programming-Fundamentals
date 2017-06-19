using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            var dragons = new Dictionary<string, SortedDictionary<string, List<int>>>(); // type, name, dammage, health, armor
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                // split input
                var input = Console.ReadLine().Split(' ');
                var type = input[0];
                var name = input[1];
                var damage = input[2] == "null"? 45 : int.Parse(input[2]);
                var health = input[3] == "null" ? 250 : int.Parse(input[3]);
                var armor = input[4] == "null" ? 10 : int.Parse(input[4]);
                
                // fill dict and list
                var stats = new List<int>
                {
                    damage, health, armor
                };
                
                if (!dragons.ContainsKey(type))
                {
                    dragons[type] = new SortedDictionary<string, List<int>>();
                }
                if (!dragons[type].ContainsKey(name))
                {
                    dragons[type][name] = new List<int>();
                }

                dragons[type][name] = stats;

            }

            foreach (var kvp in dragons)
            {
                var type = kvp.Key;
                var nameStats = kvp.Value;
                var avgDamage = nameStats.Select(x => x.Value[0]).Average();
                var avgHealth = nameStats.Select(x => x.Value[1]).Average();
                var avgArmor = nameStats.Select(x => x.Value[2]).Average();

                Console.WriteLine("{0}::({1:F2}/{2:F2}/{3:F2})", type, avgDamage, avgHealth, avgArmor);

                foreach (var innerPair in nameStats)
                {
                    var name = innerPair.Key;
                    var damage = innerPair.Value[0];
                    var health = innerPair.Value[1];
                    var armor = innerPair.Value[2];

                    Console.WriteLine("-{0} -> damage: {1}, health: {2}, armor: {3}", name, damage, health, armor);
                }
            }
            
        }
    }
}
