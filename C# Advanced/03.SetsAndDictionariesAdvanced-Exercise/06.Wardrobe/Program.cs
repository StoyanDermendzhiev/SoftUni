using System;
using System.Collections.Generic;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] clothesData = Console.ReadLine().Split(" -> ");
                string color = clothesData[0];
                string[] inputClothes = clothesData[1].Split(",");

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                foreach (var clothes in inputClothes)
                {
                    if (!wardrobe[color].ContainsKey(clothes))
                    {
                        wardrobe[color].Add(clothes, 0);
                    }

                    wardrobe[color][clothes]++;
                }
            }

            string[] search = Console.ReadLine().Split();

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var clothes in color.Value)
                {
                    if (color.Key == search[0] && clothes.Key == search[1])
                    {
                        Console.WriteLine($"* {clothes.Key} - {clothes.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothes.Key} - {clothes.Value}");
                    }
                }
            }
        }
    }
}
