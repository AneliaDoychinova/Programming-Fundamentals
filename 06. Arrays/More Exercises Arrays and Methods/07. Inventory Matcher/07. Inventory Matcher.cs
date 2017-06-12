using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Inventory_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            var productName = Console.ReadLine().Split().ToArray();
            var quantities = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var prices = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            var wantedProducts = Console.ReadLine();

            while (wantedProducts != "done")
            {
                var index = Array.IndexOf(productName, wantedProducts);
                Console.WriteLine("{0} costs: {1}; Available quantity: {2}", productName[index], prices[index],
                            quantities[index]);
                       
                wantedProducts = Console.ReadLine();
            }
        }
    }
}
