using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            Dictionary<string, int> junk = new Dictionary<string, int>();

            keyMaterials.Add("shards", 0);
            keyMaterials.Add("fragments", 0);
            keyMaterials.Add("motes", 0);

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                bool isBreak = false;

                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1].ToLower();

                    if (keyMaterials.ContainsKey(material))
                    {
                        keyMaterials[material] += quantity;
                        if (keyMaterials[material] >= 250)
                        {
                            keyMaterials[material] -= 250;
                            string legendaryItem = string.Empty;

                            switch (material)
                            {
                                case "shards":
                                    legendaryItem = "Shadowmourne";
                                    break;
                                case "fragments":
                                    legendaryItem = "Valanyr";
                                    break;
                                case "motes":
                                    legendaryItem = "Dragonwrath";
                                    break;
                            }
                            Console.WriteLine($"{legendaryItem} obtained!");
                            isBreak = true;
                            break;
                        }
                    }
                    else
                    {
                        if (junk.ContainsKey(material))
                        {
                            junk[material] += quantity;
                        }
                        else
                        {
                            junk.Add(material, quantity);
                        }
                    }
                }

                if (isBreak)
                {
                    break;
                }
            }

            foreach (var material in keyMaterials.OrderByDescending(x => x.Value)
                                                 .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }

            foreach (var material in junk.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
        }
    }
}
