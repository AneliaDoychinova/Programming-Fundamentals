using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_CIntro_and_BasicSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var thirdNum = int.Parse(Console.ReadLine());
            var forthNum = int.Parse(Console.ReadLine());

            Console.WriteLine("{0:D4} {1:D4} {2:D4} {3:D4}", firstNum, secondNum, thirdNum, forthNum);
           
        }
    }
}
