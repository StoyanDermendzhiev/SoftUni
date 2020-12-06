using System;

namespace _06.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double dogFood = double.Parse(Console.ReadLine());
            double catFood = double.Parse(Console.ReadLine());
            double turtleFood = double.Parse(Console.ReadLine());
            //Calculations
            turtleFood /= 1000;
            double totalFood = days * (dogFood + catFood + turtleFood);
            if (totalFood <= food)
            {
                double foodLeft = Math.Floor(food - totalFood);
                Console.WriteLine($"{foodLeft} kilos of food left.");
            }
            else
            {
                double foodNeeded = Math.Ceiling(totalFood - food);
                Console.WriteLine($"{foodNeeded} more kilos of food are needed.");
            }
        }
    }
}
