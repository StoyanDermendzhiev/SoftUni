using System;
using System.ComponentModel;

namespace _03.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double busPercent = 0;
            double truckPercent = 0;
            double trainPercent = 0;
            double tonsPrice = 0;
            int totalTons = 0;
            for (int i = 1; i <= number; i++)
            {
                int tons = int.Parse(Console.ReadLine());
                if (tons <= 3)
                {
                    tonsPrice += 200 * tons;
                    busPercent += tons;
                }
                else if (tons > 3 && tons <= 11)
                {
                    tonsPrice += 175 * tons;
                    truckPercent += tons;
                }
                else
                {
                    tonsPrice += 120 * tons;
                    trainPercent += tons;
                }
                totalTons += tons;
            }
            tonsPrice = tonsPrice / totalTons;
            busPercent = 1.0 * busPercent / totalTons * 100;
            truckPercent = 1.0 * truckPercent / totalTons * 100;
            trainPercent = 1.0 * trainPercent / totalTons * 100;
            Console.WriteLine($"{tonsPrice:f2}");
            Console.WriteLine($"{busPercent:f2}%");
            Console.WriteLine($"{truckPercent:f2}%");
            Console.WriteLine($"{trainPercent:f2}%");
        }
    }
}
