using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var capacity = 255;
            var totalLitters = 0;
            var overflow = false;

            for (int i = 0; i < n; i++)
            {
                var litters = int.Parse(Console.ReadLine());
                
                if (litters > capacity && n == 1)
                {
                    Console.WriteLine("Insufficient capacity!");
                    break;
                }
                if (totalLitters + litters > capacity && !overflow)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                if (!overflow)
                {
                     totalLitters += litters;
                }               
               
                
                if (totalLitters > capacity)
                {
                    overflow = true;
                    Console.WriteLine("Insufficient capacity!");
                }

            }
            Console.WriteLine(totalLitters);
        }
    }
}
