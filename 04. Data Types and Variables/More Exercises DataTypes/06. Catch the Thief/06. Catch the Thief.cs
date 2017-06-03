using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Catch_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            var idNumeralType = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());

            var biggestId = long.MinValue;

            for (int i = 0; i < n; i++)
            {
                var ids = long.Parse(Console.ReadLine());

                if (idNumeralType == "sbyte")
                {
                    if (ids > biggestId && ids <= sbyte.MaxValue)
                    {
                        biggestId = ids;
                    }

                }
                else if (idNumeralType == "int")
                {
                    if (ids > biggestId && ids <= int.MaxValue)
                    {
                        biggestId = ids;
                    }
                }
                else
                {
                     if (ids > biggestId)
                    {
                        biggestId = ids;
                    }
                }
                
            }
            Console.WriteLine(biggestId);
        }
    }
}
