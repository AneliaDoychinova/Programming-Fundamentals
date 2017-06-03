using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            
        for (int num = 1; num <= number; num++)
        {
            var sum = 0;
            bool isNum = false;
            var currentNum = num;

            while (currentNum > 0)
            {
                sum += currentNum % 10;
                currentNum = currentNum / 10;
            }

            isNum = (sum == 5) || (sum == 7) || (sum == 11);

            Console.WriteLine("{0} -> {1}",num ,isNum);
}

        }
    }
}
