using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PlantDiscovery
{
    class Plant
    {
        public int Rarity { get; set; }
        public List<double> Rating { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            Dictionary<string, Plant> plants = new Dictionary<string, Plant>();

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] inputLine = Console.ReadLine().Split("<->");

                string plantName = inputLine[0];
                int rarity = int.Parse(inputLine[1]);

                if (plants.ContainsKey(plantName))
                {
                    plants[plantName].Rarity = rarity;
                }
                else
                {
                    plants.Add(plantName, new Plant { Rarity = rarity, Rating = new List<double>() });
                }
            }

            string inputCommand = Console.ReadLine();

            while (inputCommand != "Exhibition")
            {
                string[] command = inputCommand.Split(new[] { ':', ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = command[0];
                string plantName = command[1];

                if (plants.ContainsKey(plantName))
                {
                    if (currentCommand == "Rate")
                    {
                        int rating = int.Parse(command[2]);

                        plants[plantName].Rating.Add(rating);
                    }
                    else if (currentCommand == "Update")
                    {
                        int newRarity = int.Parse(command[2]);

                        plants[plantName].Rarity = newRarity;
                    }
                    else if (currentCommand == "Reset")
                    {
                        plants[plantName].Rating.RemoveAll(x => x > 0);
                    }
                }
                else
                {
                    Console.WriteLine("error");
                }

                inputCommand = Console.ReadLine();
            }

            foreach (var plant in plants)
            {
                if (plant.Value.Rating.Count != 0)
                {
                    double avgRating = plant.Value.Rating.Average();
                    plant.Value.Rating.RemoveAll(x => x > 0);
                    plant.Value.Rating.Add(avgRating);
                }
                else
                {
                    plant.Value.Rating.Add(0);
                }
            }

            Console.WriteLine("Plants for the exhibition:");

            foreach (var plant in plants.OrderByDescending(x=>x.Value.Rarity)
                                        .ThenByDescending(x=>x.Value.Rating[0]))
            {
                
                Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value.Rarity}; Rating: {plant.Value.Rating[0]:f2}");
            }
        }
    }
}
