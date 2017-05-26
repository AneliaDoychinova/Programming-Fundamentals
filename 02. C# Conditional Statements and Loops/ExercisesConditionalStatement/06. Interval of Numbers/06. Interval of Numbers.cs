using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());

            if (firstNum > secondNum)
            {
                var temp = firstNum;
                firstNum = secondNum;
                secondNum = temp;
            }
            for (int i = firstNum; i <= secondNum; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
