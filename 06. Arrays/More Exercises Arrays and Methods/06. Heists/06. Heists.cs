using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            var prices = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var input = Console.ReadLine().Split();
            
            var totalIncome = 0;
            var totalExpences = 0;
            var jewelsPrice = prices[0];
            var goldPrice = prices[1];

            while (input[0] != "Jail")
            {
                var loot = input[0];
                var expenses = Int32.Parse(input[1]);

                for (int i = 0; i < loot.Length; i++)
                {
                    var currentChar = loot[i];

                    if (currentChar == '%')
                    {
                        totalIncome += jewelsPrice;
                    }
                    if (currentChar == '$')
                    {
                        totalIncome += goldPrice;
                    }
                }
                totalExpences += expenses;
                input = Console.ReadLine().Split();
            }
            var diff = Math.Abs(totalExpences - totalIncome);
            if (totalIncome >= totalExpences)
            {
                Console.WriteLine("Heists will continue. Total earnings: {0}.",diff);
            }
            else
            {
                Console.WriteLine("Have to find another job. Lost: {0}.", diff);
            }
        }
    }
}
