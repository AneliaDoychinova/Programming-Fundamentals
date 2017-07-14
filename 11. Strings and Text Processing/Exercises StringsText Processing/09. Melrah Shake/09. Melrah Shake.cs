using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Melrah_Shake
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine();
            var pattern = Console.ReadLine();

            while (true)
            {
                var leftIndex = inputString.IndexOf(pattern);
                var rightIndex = inputString.LastIndexOf(pattern);

                var leftIndexExists = leftIndex != -1;
                var rightIndexExists = rightIndex != -1;
                var isLeftIndexEqualRight = leftIndex == rightIndex;
                var isPatternEmpty = pattern == string.Empty;

                if (leftIndexExists && rightIndexExists && !isLeftIndexEqualRight && !isPatternEmpty)
                {
                    inputString = inputString.Remove(rightIndex, pattern.Length);
                    inputString = inputString.Remove(leftIndex, pattern.Length);

                    Console.WriteLine("Shaked it.");
                    pattern = pattern.Remove(pattern.Length/2,1);
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(inputString);
                    break;
                }
            }

        }
    }
}
