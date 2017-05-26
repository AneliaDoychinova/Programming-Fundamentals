using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());

            var megaPixels = Math.Round((width * height) / 1000000.0,1);

            Console.WriteLine("{0}x{1} => {2}MP", width, height, megaPixels);

        }
    }
}
