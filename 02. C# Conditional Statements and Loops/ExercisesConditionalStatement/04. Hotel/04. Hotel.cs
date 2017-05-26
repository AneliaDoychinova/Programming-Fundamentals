using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nightsCount = int.Parse(Console.ReadLine());

            var priceForStudio = 0.0;
            var priceForDouble = 0.0;
            var priceForSuite = 0.0;
            
            if (month == "May" || month == "October")
            {
                
                priceForStudio = 50 * nightsCount;
                priceForDouble = 65 * nightsCount;
                priceForSuite = 75 * nightsCount;
                
                if (nightsCount > 7)
                {
                    priceForStudio = priceForStudio * 0.95;
                }
            }
            else if (month == "June" || month == "September")
            {
                
                priceForStudio = 60 * nightsCount;
                priceForDouble = 72 * nightsCount;
                priceForSuite = 82 * nightsCount;
                
                if (nightsCount > 14)
                {
                    priceForDouble = priceForDouble * 0.9;
                }
            }
            else if (month == "July" || month == "August" || month == "December")
            {

                priceForStudio = 68 * nightsCount;
                priceForDouble = 77 * nightsCount;
                priceForSuite = 89 * nightsCount;

                if (nightsCount > 14)
                {
                    priceForSuite = priceForSuite * 0.85;
                }
            }

            if ((month == "September" || month == "October") && nightsCount >7)
            {
                nightsCount--;
                if (month == "September")
                {
                    priceForStudio = 60 * nightsCount;
                }
                else if (month == "October")
                {
                    priceForStudio = 50 * nightsCount * 0.95;
                }
            }

            Console.WriteLine("Studio: {0:F2} lv.", priceForStudio);
            Console.WriteLine("Double: {0:F2} lv.", priceForDouble);
            Console.WriteLine("Suite: {0:F2} lv.", priceForSuite);
        }
    }
}
