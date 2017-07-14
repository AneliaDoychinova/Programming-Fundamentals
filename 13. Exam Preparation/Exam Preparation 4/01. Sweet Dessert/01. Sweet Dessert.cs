using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = decimal.Parse(Console.ReadLine());
            var guestsNum = int.Parse(Console.ReadLine());
            var bananaPrice = double.Parse(Console.ReadLine());
            var eggPrice = double.Parse(Console.ReadLine());
            var berriesPricePerKilo = double.Parse(Console.ReadLine());

            var sets = Math.Ceiling(guestsNum / 6.0);
            double pricePerSet = (2 * bananaPrice) + (4 * eggPrice) + (berriesPricePerKilo * 0.2);

            var totalPrice = pricePerSet * sets;

            if (money >= (decimal)totalPrice)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:F2}lv.", totalPrice);
            }
            else
            {
                var diff = (decimal)totalPrice - money;
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:F2}lv more.",diff);
            }
        }
    }
}
