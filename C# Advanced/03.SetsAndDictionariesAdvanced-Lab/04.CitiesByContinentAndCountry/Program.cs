using System;
using System.Collections.Generic;

namespace _04.CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCities = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> cities = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < numberOfCities; i++)
            {
                string[] cityInfo = Console.ReadLine().Split();
                string continentName = cityInfo[0];
                string countryName = cityInfo[1];
                string cityName = cityInfo[2];

                if (!cities.ContainsKey(continentName))
                {
                    cities.Add(continentName, new Dictionary<string, List<string>>());
                    cities[continentName].Add(countryName, new List<string>());
                    cities[continentName][countryName].Add(cityName);
                }
                else
                {
                    if (!cities[continentName].ContainsKey(countryName))
                    {
                        cities[continentName].Add(countryName, new List<string>());
                        cities[continentName][countryName].Add(cityName);
                    }
                    else
                    {
                        cities[continentName][countryName].Add(cityName);
                    }
                }
            }

            foreach (var continent in cities)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
