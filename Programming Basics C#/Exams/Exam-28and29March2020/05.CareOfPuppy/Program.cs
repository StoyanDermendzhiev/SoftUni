using System;

namespace _05.CareOfPuppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int availableFood = int.Parse(Console.ReadLine());
            availableFood *= 1000;
            string input = Console.ReadLine();
            int totalEatenFood = 0;
            while (input != "Adopted")
            {
                int eatenFood = int.Parse(input);
                totalEatenFood += eatenFood;
                input = Console.ReadLine();
            }
            if (totalEatenFood > availableFood)
            {
                Console.WriteLine($"Food is not enough. You need {totalEatenFood - availableFood} grams more.");
            }
            else
            {
                Console.WriteLine($"Food is enough! Leftovers: {availableFood - totalEatenFood} grams.");
            }
        }
    }
}
