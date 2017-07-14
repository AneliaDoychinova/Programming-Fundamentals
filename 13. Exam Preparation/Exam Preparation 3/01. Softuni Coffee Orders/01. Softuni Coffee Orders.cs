using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Numerics;

namespace _01.Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var countOfOrders = int.Parse(Console.ReadLine());

            Decimal totalPrice = 0;

            for (int i = 0; i < countOfOrders; i++)
            {
                var price = decimal.Parse(Console.ReadLine());
                var orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                var capsulesCount = decimal.Parse(Console.ReadLine());
                var month = orderDate.Month;
                var year = orderDate.Year;
                var days = DateTime.DaysInMonth(year, month);
                var orderPrice = days * capsulesCount * price;
                totalPrice += orderPrice;

                Console.WriteLine("The price for the coffee is: ${0:F2}",orderPrice);
            }

            Console.WriteLine("Total: ${0:F2}", totalPrice);


        }
    }
}
