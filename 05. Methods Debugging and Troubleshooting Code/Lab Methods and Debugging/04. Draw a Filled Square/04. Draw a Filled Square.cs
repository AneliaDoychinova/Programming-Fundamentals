using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            DrawFilledSquare(n);
        }

        static void DrawFilledSquare(int n)
        {
            PrintHeaderRow(n);
            PrintMiddleRows(n);
            PrintHeaderRow(n);
        }

        static void PrintMiddleRows(int n)
        {
            for (int i = 0; i < n-2; i++)
            {
                Console.Write("-");
                for (int j  = 1; j < n; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
   
            
        }

        static void PrintHeaderRow(int n)
        {
            Console.WriteLine(new string('-', 2 *n));
        }
    }
}
