using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Andrey_and_Billiard
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var productPrice = new Dictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split('-');
                var product = input[0];
                var price = double.Parse(input[1]);

                productPrice[product] = price;

            }
            var customers = new Dictionary<string, Customer>();
            var customer = new Customer();
            var tokens = Console.ReadLine().Split(new char[] { '-', ',' },
                StringSplitOptions.RemoveEmptyEntries);

            while (tokens[0] != "end of clients")
            {
                var name = tokens[0];
                var product = tokens[1];
                var quantity = long.Parse(tokens[2]);


                if (productPrice.ContainsKey(product))
                {
                    var bill = quantity * productPrice[product];

                    if (customers.ContainsKey(name))
                    {
                        if (!customers[name].ShopList.ContainsKey(product))
                        {
                            customers[name].ShopList[product] = 0;
                        }
                        customers[name].ShopList[product] += quantity;
                        customers[name].Bill += bill;
                    }
                    else
                    {
                        var shopList = new Dictionary<string, double>();
                        shopList[product] = quantity;

                        customer = new Customer
                        {
                            Name = name,
                            ShopList = shopList,
                            Bill = bill
                        };

                        customers.Add(name, customer);
                    }

                }

                tokens = Console.ReadLine().Split(new char[] { '-', ',' },
                    StringSplitOptions.RemoveEmptyEntries);
            }

            customers = customers.Select(a => a).OrderBy(a => a.Value.Name).ToDictionary(a => a.Key, a => a.Value);

            var totalBill = 0.0;

            foreach (var kvp in customers.Values)
            {
                Console.WriteLine(kvp.Name);

                foreach (KeyValuePair<string, double> item in kvp.ShopList)
                {
                    var product = item.Key;
                    var quantity = item.Value;

                    Console.WriteLine("-- {0} - {1}", product, quantity);
                }

                Console.WriteLine("Bill: {0:F2}", kvp.Bill);
                totalBill += kvp.Bill;
            }

            Console.WriteLine("Total bill: {0:F2}", totalBill);
        }

        class Customer
        {
            public string Name { get; set; }
            public Dictionary<string, double> ShopList { get; set; }
            public double Bill { get; set; }
        }
    }
}
