using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Add_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());

            var sum = firstNum + secondNum;

            Console.WriteLine("{0} + {1} = {2}", firstNum, secondNum, sum);
        }
    }
}
