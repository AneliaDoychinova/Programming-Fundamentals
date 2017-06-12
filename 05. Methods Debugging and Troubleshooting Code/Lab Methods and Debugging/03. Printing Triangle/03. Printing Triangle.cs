﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
        }

        static void PrintTriangle(int n)
        {
            PrintUpperPart(n);

            PrintLowerPart(n);
            
        }

        static void PrintLowerPart(int n)
        {
            for (int i = n - 1; i >= 1; i--)
            {
                PrintLine(i);
            }
        }

       static void PrintUpperPart(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintLine(i);
            }
        }

        static void PrintLine(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
