using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Upgraded_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            var productName = Console.ReadLine().Split().ToArray();
            var quantities = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var prices = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            var wantedProducts = Console.ReadLine().Split();

            while (wantedProducts[0] != "done")
            {
                var wantedProduct = wantedProducts[0];
                var wantedQuantity = Int64.Parse(wantedProducts[1]);
                var currentQuantity = 0L;

                var index = Array.IndexOf(productName, wantedProduct);

                if (index <= quantities.Length-1)
                {
                    currentQuantity = quantities[index];
                }

                if (currentQuantity < wantedQuantity)
                {
                    Console.WriteLine("We do not have enough {0}", wantedProduct);
                }
                else
                {
                    quantities[index] -= wantedQuantity;
                    Console.WriteLine("{0} x {1} costs {2:F2}", wantedProduct, wantedQuantity, wantedQuantity * prices[index]);
                }

                wantedProducts = Console.ReadLine().Split();
            }
        }
    }
}
