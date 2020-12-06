using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.P_rates
{
    class City
    {
        public City(int people, int gold)
        {
            People = people;
            Gold = gold;
        }

        public int People { get; set; }
        public int Gold { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string inputCities = Console.ReadLine();

            Dictionary<string, City> cities = new Dictionary<string, City>();

            while (inputCities != "Sail")
            {
                string[] currentCity = inputCities.Split("||");
                string cityName = currentCity[0];
                int people = int.Parse(currentCity[1]);
                int gold = int.Parse(currentCity[2]);

                City city = new City(people, gold);

                if (cities.ContainsKey(cityName))
                {
                    cities[cityName].People += people;
                    cities[cityName].Gold += gold;
                }
                else
                {
                    cities.Add(cityName, city);
                }

                inputCities = Console.ReadLine();
            }

            string inputEvents = Console.ReadLine();

            while (inputEvents != "End")
            {
                string[] currentEvent = inputEvents.Split("=>");
                string eventName = currentEvent[0];
                string cityName = currentEvent[1];

                if (eventName == "Plunder")
                {
                    int people = int.Parse(currentEvent[2]);
                    int gold = int.Parse(currentEvent[3]);

                    Console.WriteLine($"{cityName} plundered! {gold} gold stolen, {people} citizens killed.");

                    cities[cityName].People -= people;
                    cities[cityName].Gold -= gold;


                    if (cities[cityName].People == 0 || cities[cityName].Gold == 0)
                    {
                        cities.Remove(cityName);

                        Console.WriteLine($"{cityName} has been wiped off the map!");
                    }
                }
                else if (eventName == "Prosper")
                {
                    int gold = int.Parse(currentEvent[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                    }
                    else
                    {
                        cities[cityName].Gold += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {cityName} now has {cities[cityName].Gold} gold.");
                    }
                }

                inputEvents = Console.ReadLine();
            }

            if (cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");

                foreach (var city in cities.OrderByDescending(x=>x.Value.Gold)
                                           .ThenBy(x=>x.Key))
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value.People} citizens, Gold: {city.Value.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
