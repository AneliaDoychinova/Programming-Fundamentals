using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.House_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());

            var sbyteNum = 0;
            var intNum = 0;

            if (firstNum > secondNum)
            {
                intNum = firstNum;
                sbyteNum = secondNum;
            }
            else
            {
                intNum = secondNum;
                sbyteNum = firstNum;
            }
            ulong totalPrice = 10 * (ulong)intNum + 4 * (ulong)sbyteNum;
            Console.WriteLine(totalPrice);
        }
    }
}
