using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Distance_between_Points
{
    class Program
    {
        class Point 
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
        static void Main(string[] args)
        {
          var pointP1=  ReadPoint();
          var pointP2 = ReadPoint();

          var distance = CalcDistance(pointP1, pointP2);

           Console.WriteLine("{0:f3}", distance);
        }

        static double CalcDistance(Point pointP1, Point pointP2)
        {
            var sideA = Math.Abs(pointP1.X - pointP2.X);
            var sideB = Math.Abs(pointP1.Y - pointP2.Y);
            var distance = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));

            return distance;
        }

       static Point ReadPoint()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var point = new Point()
            {
                X = input[0],
                Y = input[1]
            };
            return point;
        }
    }
}
