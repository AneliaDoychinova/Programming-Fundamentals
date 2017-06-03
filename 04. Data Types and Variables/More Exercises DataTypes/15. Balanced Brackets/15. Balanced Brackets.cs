using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var isOpeningBrackets = false;
            var lastBracket = string.Empty;
            var isConsecutive = false;

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();

                if (line == "(")
                {
                    if (lastBracket == "(")
                    {
                        break;
                    }
                    isOpeningBrackets = true;
                    lastBracket = line;
                }
                if (line == ")")
                {
                    if (lastBracket == "(")
	                {
                        isConsecutive = true;
                        isOpeningBrackets = false;
	                }

                    if (lastBracket == null)
                    {
                        break;
                    }
                    lastBracket = line;
                }
            }
            Console.WriteLine(isConsecutive && !isOpeningBrackets ? "BALANCED" : "UNBALANCED");
        }
    }
}
