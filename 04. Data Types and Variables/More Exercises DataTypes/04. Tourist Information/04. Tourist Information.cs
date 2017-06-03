using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Tourist_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            var imperialUnit = Console.ReadLine();
            var value = double.Parse(Console.ReadLine());

            var metricUnit = string.Empty;
            var convertedValue = 0.0;
            
            switch (imperialUnit)
            {
                case "miles":
                    metricUnit = "kilometers";
                    convertedValue = value * 1.6;
                    break;
                case "inches":
                    metricUnit = "centimeters";
                    convertedValue = value * 2.54;
                    break;
                case "feet":
                    metricUnit = "centimeters";
                    convertedValue = value * 30;
                    break;
                case "yards":
                    metricUnit = "meters";
                    convertedValue = value * 0.91;
                    break;
                case "gallons":
                    metricUnit = "liters";
                    convertedValue = value * 3.8;
                    break;

            }
            Console.WriteLine("{0} {1} = {2:F2} {3}", value, imperialUnit, convertedValue, metricUnit);
        }
    }
}
