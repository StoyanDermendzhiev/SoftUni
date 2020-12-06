using System;

namespace _03.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Static data
            double bouquet = 2;
            //Input
            int chrysanthemums = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holiday = Console.ReadLine();
            //Calculations
            double discount = 1;
            if (tulips > 7 && season == "Spring")
            {
                discount *= 0.95;
            }
            if (roses >= 10 && season == "Winter")
            {
                discount *= 0.90;
            }
            if ((chrysanthemums+roses+tulips) > 20)
            {
                discount *= 0.80;
            }
            if (holiday == "Y" && (season == "Spring" || season == "Summer"))
            {
                bouquet = ((chrysanthemums * 2.00 + roses * 4.10 + tulips * 2.50) * 1.15 * discount) + bouquet;
                Console.WriteLine($"{bouquet:f2}");
            }
            else if (holiday == "N" && (season == "Spring" || season == "Summer"))
            {
                bouquet = ((chrysanthemums * 2.00 + roses * 4.10 + tulips * 2.50) * discount) + bouquet;
                Console.WriteLine($"{bouquet:f2}");
            }
            else if (holiday == "Y" && (season == "Autumn" || season == "Winter"))
            {
                bouquet = ((chrysanthemums * 3.75 + roses * 4.50 + tulips * 4.15) * 1.15 * discount) + bouquet;
                Console.WriteLine($"{bouquet:f2}");
            }
            else if (holiday == "N" && (season == "Autumn" || season == "Winter"))
            {
                bouquet = ((chrysanthemums * 3.75 + roses * 4.50 + tulips * 4.15) * discount) + bouquet;
                Console.WriteLine($"{bouquet:f2}");
            }
        }
    }
}
