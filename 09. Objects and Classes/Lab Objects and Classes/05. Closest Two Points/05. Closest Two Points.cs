using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Closest_Two_Points
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
            var points = ReadPoints();

            var closestPoints = FindClosestPoints(points);

            var point1 = closestPoints[0];
            var point2 = closestPoints[1];

            var distance = CalcDistance(point1, point2);

            Console.WriteLine("{0:f3}", distance);
            PrintPoints(point1);
            PrintPoints(point2);
        }
           

        static void PrintPoints(Point point1)
        {
            Console.WriteLine("({0}, {1})", point1.X, point1.Y);
        }

        static Point[] FindClosestPoints(Point[] points)
        {
            var minDistance = double.MaxValue;
            Point[] closestTwoPoints = null;

            for (int p1 = 0; p1 < points.Length; p1++)
            {
                for (int p2 = p1+1; p2 < points.Length; p2++)
                {
                    double distance = CalcDistance(points[p1], points[p2]);

                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestTwoPoints = new Point[]
                        {
                            points[p1],
                            points[p2]
                        };
                    }
                }
            }

            return closestTwoPoints;
        }

        static double CalcDistance(Point point1, Point point2)
        {
            
            var sideA = Math.Abs(point1.X - point2.X);
            var sideB = Math.Abs(point1.Y - point2.Y);
            var distance = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));

            return distance;
        }

        static Point[] ReadPoints()
        {
            var count = int.Parse(Console.ReadLine());
            var points = new Point[count];

            for (int i = 0; i < count; i++)
            {
                points[i] = ReadPoint();
            }

            return points;
        }

        static Point ReadPoint()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var point = new Point
            {
                X = input[0],
                Y = input[1]
            };
            return point;
        }
    }
}
