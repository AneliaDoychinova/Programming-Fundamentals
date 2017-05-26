using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DNA_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            var matchSum = int.Parse(Console.ReadLine());

            var sumOfElements = 0;
            var count = 0;
            
            var characters = new char[4]{'A','C','G','T'};
            var values = new int[4] {1,2,3,4 };
 
            for (int i = 0; i < characters.Length; i++)
            {
                for (int j = 0; j < characters.Length; j++)
                {
                    for (int k = 0; k < characters.Length; k++)
                    {
                        sumOfElements = values[i] + values[j] + values[k];

                        if (sumOfElements >= matchSum)
                        {
                            Console.Write("O{0}{1}{2}O ", characters[i], characters[j],characters[k]);
                            count++;
                        }
                        else
                        {
                            Console.Write("X{0}{1}{2}X ", characters[i], characters[j], characters[k]);
                            count++;
                        }
                        if (count % 4 == 0)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
