using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Supermarket_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            var database = new Dictionary<string, List<double>>();

            var input = Console.ReadLine().Split(' ');

            while (input[0] != "stocked")
            {
                var name = input[0];
                var price = double.Parse(input[1]);
                var quantity = double.Parse(input[2]);

                if (!database.ContainsKey(name))
                {
                    database[name] = new List<double> {0,0};
                }

                database[name][0] = price;
                database[name][1] += quantity;

                input = Console.ReadLine().Split(' ');
            }
            var grandTotal = 0.0;

            foreach (var kvp in database)
            {
                var name = kvp.Key;
                var price = kvp.Value[0];
                var quantity = kvp.Value[1];
                var total = price * quantity;
                grandTotal += total;

                Console.WriteLine("{0}: ${1:F2} * {2} = ${3:F2}", name, price, quantity, total);

            }
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Grand Total: ${0:F2}", grandTotal);
        }
    }
}
