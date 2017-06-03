using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Boat_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstBoatCh = char.Parse(Console.ReadLine());
            var secondBoatCh = char.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());

            var firstBoatMoves = 0;
            var secondBoatMoves = 0;
            for (int i = 1; i <= n; i++)
            {
                var line = Console.ReadLine();
                
                if (line == "UPGRADE")
                {
                    firstBoatCh = (char)(firstBoatCh + 3);
                    secondBoatCh = (char)(secondBoatCh + 3);
                    continue;
                }

                if (i % 2 == 1)
                {
                    firstBoatMoves += line.Length;
                }
                else
                {
                    secondBoatMoves += line.Length;
                }

                if (firstBoatMoves >= 50 || secondBoatMoves >= 50)
                {
                    break; 
                }


            }
            Console.WriteLine(firstBoatMoves > secondBoatMoves ? firstBoatCh : secondBoatCh);

        }
    }
}
