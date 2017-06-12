using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLineX1 = double.Parse(Console.ReadLine());
            var firstLineY1 = double.Parse(Console.ReadLine());
            var firstLineX2 = double.Parse(Console.ReadLine());
            var firstLineY2 = double.Parse(Console.ReadLine());
            var secondLineX1 = double.Parse(Console.ReadLine());
            var secondLineY1 = double.Parse(Console.ReadLine());
            var secondLineX2 = double.Parse(Console.ReadLine());
            var secondLineY2 = double.Parse(Console.ReadLine());

            var firstLineLenght = FindLengthOfLine(firstLineX1,firstLineY1,firstLineX2,firstLineY2);
            var secondLineLenght = FindLengthOfLine(secondLineX1, secondLineY1, secondLineX2, secondLineY2);

            if (firstLineLenght >= secondLineLenght)
            {
                PrintPointClosestToCenterPointFirst(firstLineX1, firstLineY1, firstLineX2, firstLineY2);
            }
            else
            {
                PrintPointClosestToCenterPointFirst(secondLineX1, secondLineY1, secondLineX2, secondLineY2);
            }
        }

        static void PrintPointClosestToCenterPointFirst(double x1, double y1, double x2, double y2)
        {
            if (Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2)) <= Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2)))
            {
                Console.WriteLine("({0}, {1})({2}, {3})", x1,y1,x2,y2);
            }
            else
            {
                Console.WriteLine("({0}, {1})({2}, {3})", x2, y2, x1, y1);
            }
        }

        static double FindLongerLine(double firstLineLenght, double secondLineLenght)
        {
            if (firstLineLenght >= secondLineLenght)
            {
                return firstLineLenght;
            }
            return secondLineLenght;
        }

        static double FindLengthOfLine(double x1, double y1, double x2, double y2)
        {
            var lenght = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return lenght;
        }
    }
}
