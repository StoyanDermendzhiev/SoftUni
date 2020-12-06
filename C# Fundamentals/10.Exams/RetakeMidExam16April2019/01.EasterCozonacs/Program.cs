using System;

namespace _01.EasterCozonacs
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double flourPrice = double.Parse(Console.ReadLine());

            double eggsPrice = flourPrice * 0.75;
            double milkPrice = flourPrice + flourPrice * 0.25;

            double cozonacPrice = flourPrice + eggsPrice + milkPrice / 4;

            int cozonacCount = 0;
            int coloredEggsCount = 0;

            while (budget > cozonacPrice)
            {
                budget -= cozonacPrice;
                cozonacCount++;
                coloredEggsCount += 3;

                if (cozonacCount % 3 == 0)
                {
                    coloredEggsCount -= cozonacCount - 2;
                }
            }

            Console.WriteLine($"You made {cozonacCount} cozonacs! Now you have {coloredEggsCount} eggs and {budget:f2}BGN left.");
        }
    }
}
