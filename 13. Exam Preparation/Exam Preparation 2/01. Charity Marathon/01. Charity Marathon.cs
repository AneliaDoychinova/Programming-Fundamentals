using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var runners = long.Parse(Console.ReadLine());
            var avgNumOfLaps = int.Parse(Console.ReadLine());
            var trackLenght = long.Parse(Console.ReadLine());
            var trackCapacity = int.Parse(Console.ReadLine());
            var moneyPerKm = double.Parse(Console.ReadLine());

            var maxRunners = Math.Min(trackCapacity * days, runners);
            var totalMeters = maxRunners * trackLenght * avgNumOfLaps;
            var totalKilometers = totalMeters / 1000;
            var moneyRaised = totalKilometers * moneyPerKm;

            Console.WriteLine("Money raised: {0:f2}",moneyRaised);

        }
    }
}
