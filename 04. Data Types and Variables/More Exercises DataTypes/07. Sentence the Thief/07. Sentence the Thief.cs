using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sentence_the_Thief
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
            var years = 0.0;

                if (biggestId< 0)
                {
                    years = Math.Ceiling((double)biggestId / sbyte.MinValue);
                }
                else
                {
                    years = Math.Ceiling((double)biggestId / sbyte.MaxValue);
                }
                
         
                    Console.WriteLine("Prisoner with id {0} is sentenced to {1} {2}", biggestId, years, years == 1 ? "year" : "years");
               
                


      
        }
    }
}
