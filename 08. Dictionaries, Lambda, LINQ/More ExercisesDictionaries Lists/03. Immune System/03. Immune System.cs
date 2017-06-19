using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Immune_System
{
    class Program
    {
        static void Main(string[] args)
        {
            var initialHealth = double.Parse(Console.ReadLine());
            var currentHealth = initialHealth;
            var encounteredViruses = new Dictionary<string, int>();
            var input = Console.ReadLine();
            var isDefeated = false;

            while (input != "end")
            {
                var virusName = input;
                var virusStrenght = virusName.Sum(x => x)/3;
                var timeToDefeat = virusStrenght * virusName.Length;
                
                if (!encounteredViruses.ContainsKey(virusName))
                {
                    encounteredViruses[virusName] = 1;
                }
                else if (encounteredViruses[virusName] >= 1)
	            {
                    encounteredViruses[virusName]++;
                    timeToDefeat = timeToDefeat / 3;
	            }

                var minutes = timeToDefeat / 60;
                var seconds = timeToDefeat % 60;
                var remainingHealth = Math.Floor(currentHealth - timeToDefeat);
                
                Console.WriteLine("Virus {0}: {1} => {2} seconds", virusName,virusStrenght, timeToDefeat);

                if (timeToDefeat > currentHealth)
                {
                    Console.WriteLine("Immune System Defeated.");
                    isDefeated = true;
                    break;
                }
                else
                {
                    
                    Console.WriteLine("{0} defeated in {1}m {2}s.",virusName, minutes, seconds);
                    Console.WriteLine("Remaining health: {0}", remainingHealth);
                }
                

                currentHealth = Math.Min(remainingHealth * 1.2, initialHealth);

                input = Console.ReadLine();
            }

            if (!isDefeated)
            {
                Console.WriteLine("Final Health: {0}", (int)currentHealth);
            }
            

        }
    }
}
