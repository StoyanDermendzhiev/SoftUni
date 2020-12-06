using System;

namespace _02.CatWalking
{
    class Program
    {
        static void Main(string[] args)
        {
            //Static data
            int caloriesBurnPerMinute = 5;
            //Input
            int minutesWalk = int.Parse(Console.ReadLine());
            int walksNumber = int.Parse(Console.ReadLine());
            int caloriesTake = int.Parse(Console.ReadLine());
            //Calculations
            double burnedCalories = minutesWalk * walksNumber * caloriesBurnPerMinute;
            if (burnedCalories >= (caloriesTake * 0.5))
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {burnedCalories}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {burnedCalories}.");
            }
        }
    }
}
