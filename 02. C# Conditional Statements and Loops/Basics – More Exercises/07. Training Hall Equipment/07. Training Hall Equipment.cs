using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var numberOfItems = int.Parse(Console.ReadLine());

            var sum = 0.0;

            for (int i = 0; i < numberOfItems; i++)
            {
                var itemName = Console.ReadLine();
                var itemPrice =double.Parse(Console.ReadLine());
                var itemCount = int.Parse(Console.ReadLine());

                if (itemCount > 1)
                {
                    Console.WriteLine("Adding {0} {1}s to cart.", itemCount,itemName);
                }
                else
                {
                    Console.WriteLine("Adding {0} {1} to cart.", itemCount, itemName);
                }
                sum += itemPrice * itemCount;


            }
            Console.WriteLine("Subtotal: ${0:F2}", sum);
            if (sum > budget)
            {
                Console.WriteLine("Not enough. We need ${0:F2} more.",sum - budget);
            }
            else
            {
                Console.WriteLine("Money left: ${0:F2}", budget - sum);
            }
        }
    }
}
