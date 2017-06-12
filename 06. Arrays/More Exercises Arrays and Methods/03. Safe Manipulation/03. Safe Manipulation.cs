using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Safe_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split().ToArray();
            var input = Console.ReadLine().Split();

            while (input[0] != "END")
            {
                if (input[0] == "Distinct")
                {
                    var DistinctElements = words.Distinct().ToArray();
                    words = DistinctElements;
                }
                else if (input[0] == "Reverse")
                {
                    Array.Reverse(words);
                }
                else if(input[0] == "Replace")
                {
                    var index = Int32.Parse(input[1]);
                    var newString = input[2];
                    
                    if (index>=0 && index <= words.Length-1)
                    {
                        words[index] = newString;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                input = Console.ReadLine().Split();   
            }
            Console.WriteLine(string.Join(", ",words));
        }
    }
}
