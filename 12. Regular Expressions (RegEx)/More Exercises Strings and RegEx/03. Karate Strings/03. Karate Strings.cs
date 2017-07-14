using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Karate_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var strenght = 0;

            for (int i = 0; i < input.Length; i++)
            {
                var currentLetter = input[i];

                if (currentLetter == '>')
                {
                    strenght += int.Parse(input[i + 1].ToString());

                    if (input[i+1] != '>' && strenght > 0)
                    {
                        input = input.Remove(i + 1, 1);
                        strenght--;
                    }
                }
                else
                {
                    if (strenght > 0)
                    {
                        input = input.Remove(i, 1);
                        strenght--;
                        i--;
                    }
                }
            }

            Console.WriteLine(input);
        }
    }
}
