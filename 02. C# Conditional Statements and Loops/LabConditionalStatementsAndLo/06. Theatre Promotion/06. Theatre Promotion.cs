using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            var typeOfDay = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());

            var price = 0;

            if (age >= 0 && age <= 18)
            {
                if (typeOfDay == "Weekday")
                {
                    price = 12;
                }
                else if (typeOfDay == "Weekend")
                {
                    price = 15;
                }
                else
                {
                    price = 5;
                }
            }
            else if (age > 18 && age <= 64)
            {
                if (typeOfDay == "Weekday")
                {
                    price = 18;
                }
                else if (typeOfDay == "Weekend")
                {
                    price = 20;
                }
                else
                {
                    price = 12;
                }
            }
            else if (age > 64 && age <= 122)
            {
                if (typeOfDay == "Weekday")
                {
                    price = 12;
                }
                else if (typeOfDay == "Weekend")
                {
                    price = 15;
                }
                else
                {
                    price = 10;
                }
            }
            else
            {
                Console.WriteLine("Error!");
            }

            if (price != 0)
            {
                Console.WriteLine("{0}$", price);
            }
            
        }
    }
}
