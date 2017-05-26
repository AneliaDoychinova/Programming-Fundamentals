using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());

            var price = 0.0;

            switch (profession)
            {
                case "Athlete":
                    price = quantity * 0.70;
                    Console.WriteLine("The {0} has to pay {1:F2}.",profession, price);

                    break;

                case "Businessman":
                case "Businesswoman":
                    price = quantity * 1;
                    Console.WriteLine("The {0} has to pay {1:F2}.",profession, price);
                    break;

                case "SoftUni Student":
                    price = quantity * 1.70;
                    Console.WriteLine("The {0} has to pay {1:F2}.",profession, price);
                    break;

                default:
                   price = quantity * 1.2;
                    Console.WriteLine("The {0} has to pay {1:F2}.",profession, price);
                    break;
            }
        }
    }
}
