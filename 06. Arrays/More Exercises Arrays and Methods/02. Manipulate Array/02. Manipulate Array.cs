using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Manipulate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringArray = Console.ReadLine().Split().ToArray();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var commands = Console.ReadLine().Split();

                if (commands[0] == "Distinct")
                {
                    var DistinctElements = stringArray.Distinct().ToArray();
                    stringArray = DistinctElements;
                }
                else if (commands[0] == "Reverse")
                {
                    Array.Reverse(stringArray);
                }
                else
                {
                   var index = Int32.Parse( commands[1]);
                    var newString = commands[2];
                    stringArray[index] = newString;
                }
            }
            Console.WriteLine(string.Join(", ", stringArray));

        }
    }
}
