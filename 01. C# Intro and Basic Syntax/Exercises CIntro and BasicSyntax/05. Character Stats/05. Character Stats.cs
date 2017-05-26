using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var currentHealth = int.Parse(Console.ReadLine());
            var maximumHealth = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var maximumEnergy = int.Parse(Console.ReadLine());

            var healthLines = currentHealth;
            var healthDots = maximumHealth - currentHealth;

            var energyLines = currentEnergy;
            var energyDots = maximumEnergy - currentEnergy;

            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Health: |{0}{1}|", new string('|', healthLines), new string('.', healthDots));
            Console.WriteLine("Energy: |{0}{1}|", new string('|', energyLines), new string('.', energyDots));


        }
    }
}
