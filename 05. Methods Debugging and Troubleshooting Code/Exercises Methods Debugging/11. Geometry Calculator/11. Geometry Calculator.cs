using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();
            var area = 0.0;

            if (figure == "triangle")
            {
                var side = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());

                area = GetAreaOfTriangle(side,height); 
            }
            else if (figure == "square")
            {
                var side = double.Parse(Console.ReadLine());
                area = GetAreaOfSquare(side); 
            }
            else if (figure == "rectangle")
            {
                var width = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());

                area = GetAreaOfRectangle(width, height); 
            }
            else if (figure == "circle")
            {
                var radius = double.Parse(Console.ReadLine());

                area = GetAreaOfCircle(radius);
            }

            Console.WriteLine("{0:F2}", area);
        }

        static double GetAreaOfCircle(double radius)
        {
            return Math.PI * radius * radius;
        }

        static double GetAreaOfRectangle(double width, double height)
        {
            return width * height;
        }

        static double GetAreaOfSquare(double side)
        {
            return side * side;
        }

        static double GetAreaOfTriangle(double side, double height)
        {
            return side * height / 2;
        }
    }
}
