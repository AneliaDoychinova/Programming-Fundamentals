using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Vapor_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentBalance = double.Parse(Console.ReadLine());

            var input = Console.ReadLine();

            var moneyLeft = currentBalance;
            var price = 0.0;
            var isFound = true;

            while (input!="Game Time")
            {
                
                switch (input)
                {
                    case "OutFall 4":
                        price = 39.99;
                        break;
                    case "CS: OG":
                        price = 15.99;
                        break;
                    case "Zplinter Zell":
                        price = 19.99;
                        break;
                    case "Honored 2":
                        price = 59.99;
                        break;
                    case "RoverWatch":
                        price = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        price = 39.99;
                        break;
                    default:
                        isFound = false;
                        Console.WriteLine("Not Found");
                        break;
                }
                if (moneyLeft < price && isFound)
                {
                    Console.WriteLine("Too Expensive");
                }
                else if(moneyLeft >= price && isFound )
                {
                    moneyLeft = moneyLeft - price;
                    Console.WriteLine("Bought {0}", input);
                }
                

                if (moneyLeft <= 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
                isFound = true;
                input = Console.ReadLine();

            }
            if (input == "Game Time")
            {
                Console.WriteLine("Total spent: ${0:F2}. Remaining: ${1:F2}", currentBalance - moneyLeft, moneyLeft);
            }
        }
    }
}
