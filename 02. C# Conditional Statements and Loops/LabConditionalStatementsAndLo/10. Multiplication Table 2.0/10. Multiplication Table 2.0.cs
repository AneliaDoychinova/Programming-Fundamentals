using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var multiplier = int.Parse(Console.ReadLine());

            if (multiplier > 10)
            {
                var product = number * multiplier;
                Console.WriteLine("{0} X {1} = {2}", number,multiplier,product);
            }
            for (int i = multiplier; i <= 10; i++)
            {
                var product = number * i;
                Console.WriteLine("{0} X {1} = {2}", number, i, product);
            }
        }
    }
}
