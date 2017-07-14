using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _08.Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = Console.ReadLine()
                .Split(new char[] {' ','\t','\r','\n'}, StringSplitOptions.RemoveEmptyEntries);

            var totalSum = 0m;

            for (int i = 0; i < strings.Length; i++)
            {
                var resultNum = 0m;
                var currentString = strings[i];
                var firstLetter = currentString.First();
                var secondLetter = currentString.Last();
                var number = decimal.Parse(currentString.Substring(1, currentString.Length - 2));

                if (char.IsUpper(firstLetter))
                {
                    resultNum = number / (firstLetter - 64);
                }
                else
                {
                    resultNum = number * (firstLetter - 96);
                }

                if (char.IsUpper(secondLetter))
                {
                    resultNum = resultNum - (secondLetter- 64);
                }
                else
                {
                    resultNum = resultNum + (secondLetter - 96);
                }

                totalSum += resultNum;
            }
            Console.WriteLine("{0:F2}",totalSum);



        }
    }
}
