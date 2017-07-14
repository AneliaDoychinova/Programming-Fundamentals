using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var listOfCities = new Dictionary<string,Weather>();
            var regex = @"([A-Z]{2})([0-9]+).([0-9]+)[a-zA-Z]+\|";
            var cityPattern = @"[A-Z]{2}";
            var tempPattern = @"\d+.\d+";
            
            while (text != "end")
            {
                Match match = Regex.Match(text,regex);
                if (!match.Success)
                {
                    text = Console.ReadLine();
                    continue;
                }
                string stringMatch = match.Value;
                string city = Regex.Match(stringMatch, cityPattern).Value;
                string temp = Regex.Match(stringMatch, tempPattern).Value;
                string type = stringMatch.Substring(city.Length + temp.Length, match.Length - 1 - city.Length - temp.Length);

                if (!listOfCities.ContainsKey(city))
                {
                    Weather weatherCity = new Weather {Name = city, Temperature = double.Parse(temp), TypeOfWeather = type };
                    listOfCities[city] = weatherCity;
                }
                else
                {
                    listOfCities[city].Temperature = double.Parse(temp);
                    listOfCities[city].TypeOfWeather = type;
                }
                text = Console.ReadLine();
            }

            foreach (var city in listOfCities.OrderBy(a => a.Value.Temperature))
            {
                    
                Console.WriteLine("{0} => {1:F2} => {2}", city.Key, city.Value.Temperature, city.Value.TypeOfWeather);
                    
            }
        }

        class Weather
        {
            public string Name { get; set; }

            public double Temperature { get; set; }

            public string TypeOfWeather { get; set; }
        }
    }
}
