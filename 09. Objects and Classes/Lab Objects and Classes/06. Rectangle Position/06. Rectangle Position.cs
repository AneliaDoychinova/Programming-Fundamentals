using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rectangle_Position
{
    class Program
    {
        class Rectangle
        {
            public int Top { get; set; }
            public int Left { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }

            int Right
            {
                get
                {
                    return Left + Width;
                }
            }

            int Bottom
            {
                get
                {
                    return Top + Height;
                }
            }

            public bool IsInside(Rectangle rect2)
            {
                var isInLeft = Left >= rect2.Left;
                var isInRight = Right <= rect2.Right;
                var isInsideHorizontal = isInLeft & isInRight;

                var isInTop = Top >= rect2.Top;
                var isInBottom = Bottom <= rect2.Bottom;
                var isInsideVertical = isInTop & isInBottom;

                return isInsideHorizontal & isInsideVertical;

            }
        };

        static void Main(string[] args)
        {
            int[] rectArgs1 = ReadRectangle();
            int[] rectArgs2 = ReadRectangle();

            Rectangle rect1 = ParseRectangle(rectArgs1);
            Rectangle rect2 = ParseRectangle(rectArgs2);

            bool isInside = rect1.IsInside(rect2);

            PrintOutput(isInside);
    
        }

        static Rectangle ParseRectangle(int[] rectArgs)
        {
            Rectangle rectangle = new Rectangle
            {
                Left = rectArgs[0],
                Top =  rectArgs[1],
                Width = rectArgs[2],
                Height  = rectArgs[3]
                
            };

            return rectangle;
        }

        static int[] ReadRectangle()
        {
            return Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }

        static void PrintOutput(bool isInside)
        {
            if (isInside)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }
    }
}
