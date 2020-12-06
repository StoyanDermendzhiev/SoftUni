using System;

namespace _03.AnimalType
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string animal = Console.ReadLine();
            //Calculations
            switch (animal)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
