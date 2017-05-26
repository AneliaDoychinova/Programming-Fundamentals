using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var magicalNum = int.Parse(Console.ReadLine());

            var sum = 0;
            var firstNum = 0;
            var secondNum = 0;
            var isFound = false;
            var totalCombination = 0;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    sum = i + j;
                    totalCombination++;
                    if (sum == magicalNum)
                    {
                        firstNum = i;
                        secondNum = j;
                        isFound = true;
                    }
                }
            }
            if (isFound)
            {
                Console.WriteLine("Number found! {0} + {1} = {2}", firstNum, secondNum, magicalNum);
            }
            else
            {
                Console.WriteLine("{0} combinations - neither equals {1}", totalCombination, magicalNum);
            }


        }
    }
}
