using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.String_Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            var delimeter = char.Parse(Console.ReadLine());
            var oddOrEven = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());

            var output = string.Empty;
            var word = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                word = Console.ReadLine();

                if (oddOrEven == "odd")
                {
                    if (i % 2 == 1)
                    {
                        output += word + delimeter;
                    }
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        output += word + delimeter;
                    }
                }
            }
            output = output.Remove(output.Length - 1);
            Console.WriteLine(output);
        }
    }
}
