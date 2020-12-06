using System;

namespace _04.MovieStars
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string actorName = Console.ReadLine();
            while (actorName != "ACTION")
            {
                if (actorName.Length <= 15)
                {
                    double moneyPerActor = double.Parse(Console.ReadLine());
                    budget -= moneyPerActor;
                }
                else
                {
                    double moneyForLongNameActor = budget * 0.2;
                    budget -= moneyForLongNameActor;
                }
                if (budget <= 0)
                {
                    Console.WriteLine($"We need {Math.Abs(budget):f2} leva for our actors.");
                    return;
                }
                actorName = Console.ReadLine();
            }
            Console.WriteLine($"We are left with {budget:f2} leva.");
        }
    }
}
