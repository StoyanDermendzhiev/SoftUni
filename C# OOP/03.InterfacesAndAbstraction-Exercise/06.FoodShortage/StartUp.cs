using System;
using System.Collections.Generic;
using System.Linq;
using _06.FoodShortage.Contracts;
using _06.FoodShortage.Models;

namespace _06.FoodShortage
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, IBuyer> buyers = new Dictionary<string, IBuyer>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];
                int age = int.Parse(input[1]);

                if (input.Length == 4)
                {
                    string id = input[2];
                    string birthdate = input[3];

                    buyers.Add(name, new Citizen(name, age, id, birthdate));
                }
                else if (input.Length == 3)
                {
                    string group = input[2];

                    buyers.Add(name, new Rebel(name, age, group));
                }
            }

            while (true)
            {
                string inputName = Console.ReadLine();

                if (inputName == "End")
                {
                    break;
                }

                if (buyers.ContainsKey(inputName))
                {
                    buyers[inputName].BuyFood();
                }
            }

            int totalFood = buyers.Values.Sum(c => c.Food);

            Console.WriteLine(totalFood);
        }
    }
}
