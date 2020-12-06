using System;

namespace _05.EasterBake
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterBreadNumber = int.Parse(Console.ReadLine());
            double totalSugar = 0;
            double totalFlour = 0;
            int maxSugar = int.MinValue;
            int maxFlour = int.MinValue;

            for (int easterBread = 1; easterBread <= easterBreadNumber; easterBread++)
            {
                int sugar = int.Parse(Console.ReadLine());
                int flour = int.Parse(Console.ReadLine());

                totalSugar += sugar;
                totalFlour += flour;

                if (maxSugar < sugar)
                {
                    maxSugar = sugar;
                }
                if (maxFlour < flour)
                {
                    maxFlour = flour;
                }
            }
            totalSugar = Math.Ceiling(totalSugar / 950);
            totalFlour = Math.Ceiling(totalFlour / 750);

            Console.WriteLine($"Sugar: {totalSugar}");
            Console.WriteLine($"Flour: {totalFlour}");
            Console.WriteLine($"Max used flour is {maxFlour} grams, max used sugar is {maxSugar} grams.");
        }
    }
}
