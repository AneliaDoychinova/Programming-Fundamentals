using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var rectanglePerimeter = 2 * width + 2 * height;
            var rectangleArea = width * height;
            var rectangleDiagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));

            Console.WriteLine(rectanglePerimeter);
            Console.WriteLine(rectangleArea);
            Console.WriteLine(rectangleDiagonal);


        }
    }
}
