using System;

namespace _04.FoodForPets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double totalFood = double.Parse(Console.ReadLine());
            double bisquits = 0;
            double totalDogFoodEaten = 0;
            double totalCatFoodEaten = 0;
            double totalFoodEaten = 0;
            for (int i = 1; i <= days; i++)
            {
                int eatenDogFoodPerDay = int.Parse(Console.ReadLine());
                int eatenCatFoodPerDay = int.Parse(Console.ReadLine());
                if (i % 3 == 0)
                {
                    bisquits += (eatenDogFoodPerDay + eatenCatFoodPerDay) * 0.1;
                }
                totalDogFoodEaten += eatenDogFoodPerDay;
                totalCatFoodEaten += eatenCatFoodPerDay;
            }
            totalFoodEaten = totalDogFoodEaten + totalCatFoodEaten;
            totalDogFoodEaten = totalDogFoodEaten / totalFoodEaten * 100;
            totalCatFoodEaten = totalCatFoodEaten / totalFoodEaten * 100;
            totalFoodEaten = totalFoodEaten / totalFood * 100;
            Console.WriteLine($"Total eaten biscuits: {Math.Round(bisquits)}gr.");
            Console.WriteLine($"{totalFoodEaten:f2}% of the food has been eaten.");
            Console.WriteLine($"{totalDogFoodEaten:f2}% eaten from the dog.");
            Console.WriteLine($"{totalCatFoodEaten:f2}% eaten from the cat.");
        }
    }
}
