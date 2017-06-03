using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var biggestKegName = string.Empty;
            var biggestKegVolume = 0.0;
            for (int i = 0; i < n; i++)
            {
                var model = Console.ReadLine();
                var radius = double.Parse(Console.ReadLine());
                var height = int.Parse(Console.ReadLine());

                var volume = Math.PI * Math.Pow(radius, 2) * height;

                if (volume > biggestKegVolume)
                {
                    biggestKegVolume = volume;
                    biggestKegName = model;
                }
            }
            Console.WriteLine(biggestKegName);
        }
    }
}
