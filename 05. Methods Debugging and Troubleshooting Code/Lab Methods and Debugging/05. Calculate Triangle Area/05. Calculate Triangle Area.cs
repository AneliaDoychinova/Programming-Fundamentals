using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var triangleArea = CalculateTriangleArea(width, height);

            Console.WriteLine(triangleArea);
        }

        static double CalculateTriangleArea(double width, double height)
        {
            return width * height / 2;
        }
    }
}
