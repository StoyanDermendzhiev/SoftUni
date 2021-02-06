using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Cooking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> foods = new Dictionary<int, string>()
            {
                { 25, "Bread" },
                { 50, "Cake" },
                { 75, "Pastry" },
                { 100, "Fruit Pie" }
            };

            Dictionary<string, int> cookedFoods = new Dictionary<string, int>()
            {
                { "Bread", 0 },
                { "Cake", 0 },
                { "Pastry", 0 },
                { "Fruit Pie", 0 }
            };

            var liquids = new Queue<int>(Console.ReadLine()
                                                .Split()
                                                .Select(int.Parse)
                                                .ToArray());
            var ingredients = new Stack<int>(Console.ReadLine()
                                                .Split()
                                                .Select(int.Parse)
                                                .ToArray());

            while (liquids.Count != 0 && ingredients.Count != 0)
            {
                int currLiquid = liquids.Dequeue();
                int currIngredient = ingredients.Pop();

                if (foods.ContainsKey(currLiquid + currIngredient))
                {
                    string currCookedFood = foods[currLiquid + currIngredient];
                    cookedFoods[currCookedFood]++;
                }
                else
                {
                    currIngredient += 3;
                    ingredients.Push(currIngredient);
                }
            }

            bool isEnough = true;

            foreach (var product in cookedFoods)
            {
                if (product.Value == 0)
                {
                    isEnough = false;
                }
            }

            if (isEnough)
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }

            if (liquids.Count != 0)
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", liquids)}");
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }

            if (ingredients.Count != 0)
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", ingredients)}");
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }

            foreach (var product in cookedFoods.OrderBy(p => p.Key))
            {
                Console.WriteLine($"{product.Key}: {product.Value}");
            }
        }
    }
}
