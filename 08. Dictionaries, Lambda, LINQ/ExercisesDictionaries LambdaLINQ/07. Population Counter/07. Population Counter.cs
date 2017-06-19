using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('|');

            var populationByCitiesAndCountries = new Dictionary<string, Dictionary<string, long>>();

            while (input[0] != "report")
            {
                var city = input[0];
                var country = input[1];
                var population = long.Parse(input[2]);

                if (!populationByCitiesAndCountries.ContainsKey(country))
                {
                    populationByCitiesAndCountries[country] = new Dictionary<string, long>();
                    
                }
                if (!populationByCitiesAndCountries[country].ContainsKey(city))
                {
                    populationByCitiesAndCountries[country][city] = 0;
                }
                populationByCitiesAndCountries[country][city] += population;

                input = Console.ReadLine().Split('|');
            }

            var sortedByCountry = populationByCitiesAndCountries.OrderByDescending(kvp => kvp.Value.Values.Sum())
              .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);


            foreach (var countryCity in sortedByCountry)
            {
                var country = countryCity.Key;
                var populationByCities = countryCity.Value;
                var sum = populationByCities.Values.Sum();

                Console.WriteLine("{0} (total population: {1})", country,sum);

                var sortedByCity = populationByCities.OrderByDescending(x => x.Value);

                foreach (var city in sortedByCity)
                {
                    var cityName = city.Key;
                    var population = city.Value;

                    Console.WriteLine("=>{0}: {1}", cityName, population);
                }
            }
        }
    }
}
