using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            var groupSize = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();

            var hallName = string.Empty;
            var price = 0.0;
            var totalPrice = 0.0;

            if (groupSize >= 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                if (groupSize <= 50)
                {
                    hallName = "Small Hall";
                    price = 2500;
                }
                else if (groupSize <= 100)
                {
                    hallName = "Terrace";
                    price = 5000;
                }
                else if (groupSize <= 120)
                {
                    hallName = "Great Hall";
                    price = 7500;
                }

                if (package == "Normal")
                {
                    totalPrice = (price + 500) * 0.95;
                }
                else if (package == "Gold")
                {
                    totalPrice = (price + 750) * 0.9;
                }
                else
                {
                    totalPrice = (price + 1000) * 0.85;
                }
                var pricePerPerson = totalPrice / groupSize;

                Console.WriteLine("We can offer you the {0}", hallName);
                Console.WriteLine("The price per person is {0:F2}$", pricePerPerson);
            }
        }
    }
}
