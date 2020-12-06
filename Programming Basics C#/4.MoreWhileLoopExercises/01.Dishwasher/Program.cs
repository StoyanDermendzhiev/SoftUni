using System;

namespace _01.Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int bottles = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int dishesCount = 0;
            int potsCount = 0;
            int loadCount = 0;
            bottles *= 750;
            while (input != "End")
            {
                int dishesAndPots = int.Parse(input);
                loadCount++;
                if (loadCount % 3 != 0)
                {
                    dishesCount += dishesAndPots;
                    bottles -= dishesAndPots * 5;
                }
                else
                {
                    potsCount += dishesAndPots;
                    bottles -= dishesAndPots * 15;
                }
                if (bottles<0)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(bottles)} ml. more necessary!");
                    Environment.Exit(0);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Detergent was enough!");
            Console.WriteLine($"{dishesCount} dishes and {potsCount} pots were washed.");
            Console.WriteLine($"Leftover detergent {bottles} ml.");
        }
    }
}
