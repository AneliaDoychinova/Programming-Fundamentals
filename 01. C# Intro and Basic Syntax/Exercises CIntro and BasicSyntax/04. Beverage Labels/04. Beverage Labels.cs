using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energyContent = int.Parse(Console.ReadLine()); ;
            var sugarContent = int.Parse(Console.ReadLine());

            var totalEnergy = energyContent * volume / 100.0;
            var totalSugar = sugarContent * volume / 100.0;

            Console.WriteLine("{0}ml {1}:", volume, name);
            Console.WriteLine("{0}kcal, {1}g sugars", totalEnergy, totalSugar);
        }
    }
}
