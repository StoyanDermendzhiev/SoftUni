using System;

namespace _03.FitnessCard
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            char sex = char.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();
            double cardPrice = 0;
            if (sex == 'm')
            {
                switch (sport)
                {
                    case "Gym":
                        cardPrice = 42;
                        break;
                    case "Boxing":
                        cardPrice = 41;
                        break;
                    case "Yoga":
                        cardPrice = 45;
                        break;
                    case "Zumba":
                        cardPrice = 34;
                        break;
                    case "Dances":
                        cardPrice = 51;
                        break;
                    case "Pilates":
                        cardPrice = 39;
                        break;
                }
            }
            else if (sex == 'f')
            {
                switch (sport)
                {
                    case "Gym":
                        cardPrice = 35;
                        break;
                    case "Boxing":
                        cardPrice = 37;
                        break;
                    case "Yoga":
                        cardPrice = 42;
                        break;
                    case "Zumba":
                        cardPrice = 31;
                        break;
                    case "Dances":
                        cardPrice = 53;
                        break;
                    case "Pilates":
                        cardPrice = 37;
                        break;
                }
            }
            if (age <= 19)
            {
                cardPrice -= cardPrice * 0.2;
            }
            if (money >= cardPrice)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${(cardPrice - money):f2} more.");
            }
        }
    }
}
