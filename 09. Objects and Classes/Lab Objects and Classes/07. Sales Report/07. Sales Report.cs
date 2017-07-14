using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sales_Report
{
    class Program
    {
        class Sale
        {
            public string Town { get; set; }
            public string Product { get; set; }
            public double Price { get; set; }
            public double Quantity { get; set; }

        }

        class SalesByCity
        {
            public string Town { get; set; }
            public double Sales { get; set; }
        }
        static void Main(string[] args)
        {
            Sale [] sales = ReadSales();

            var salesByCity = CalcSalesByCity(sales);

            PrintSales(salesByCity);
        }

        static void PrintSales(List<SalesByCity> salesByCity)
        {
            foreach (var s in salesByCity)
            {
                Console.WriteLine("{0} -> {1:F2}", s.Town, s.Sales);
            }
        }

        static List<SalesByCity> CalcSalesByCity(Sale[] sales)
        {
            var salesByCity = new SortedDictionary<string, double>();

            foreach (var s in sales)
            {
                if (!salesByCity.ContainsKey(s.Town))
                {
                    salesByCity[s.Town] = 0;
                }
                salesByCity[s.Town] += s.Price * s.Quantity;
            }
          var salesList = salesByCity.Select(s => new SalesByCity { Town = s.Key, Sales = s.Value }).ToList();
            return salesList;
        }

        static Sale[] ReadSales()
        {
            var n = int.Parse(Console.ReadLine());
            
            var sales = new Sale[n];

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');

                sales[i] = new Sale
                {
                    Town = input[0],
                    Product = input[1],
                    Price = double.Parse(input[2]),
                    Quantity = double.Parse(input[3])
                };
            }

            return sales;
        }
    }
}
