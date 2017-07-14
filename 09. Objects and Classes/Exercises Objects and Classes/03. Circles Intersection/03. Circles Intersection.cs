using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Circles_Intersection
{
    class Program
    {
        class Circle
        {
            public Point Center { get; set; }
            public int Radius { get; set; }
        }
        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
        static void Main(string[] args)
        {
            var firstCircle = ReadCircle();
            var secondCircle = ReadCircle();

            var isIntersect = Intersect(firstCircle, secondCircle);

            PrintOutput(isIntersect);
        }

        static bool Intersect(Circle firstCircle, Circle secondCircle)
        {
            var distance = Math.Sqrt(Math.Pow(firstCircle.Center.X - secondCircle.Center.X, 2) + 
                Math.Pow(firstCircle.Center.Y - secondCircle.Center.Y, 2));

            if (distance <= firstCircle.Radius+secondCircle.Radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void PrintOutput(bool isIntersect)
        {
            if (isIntersect)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static Circle ReadCircle()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var circle = new Circle
            {
                Center = new Point { X = input[0], Y = input[1]},
                Radius = input[2]
            };
            return circle;

        }
    }
}
