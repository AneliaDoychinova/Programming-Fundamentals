using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var m = long.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            var count = 0;
            var halfN = n / 2.0;
            while (n>=m)
            {
                n -= m;
                count++;
                if (n == halfN && y != 0)
                {
                    n = n / y;
                }
                
            }
            Console.WriteLine(n);
            Console.WriteLine(count);
        }
    }
}
