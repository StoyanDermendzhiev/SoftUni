using System;

namespace _05.SuitcasesLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            double planeTrunkVolume = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int suitcaseCount = 0;
            while (input != "End")
            {
                double suitcaseVolume = double.Parse(input);
                suitcaseCount++;
                if (suitcaseCount % 3 == 0)
                {
                    suitcaseVolume *= 1.1;
                }                             
                planeTrunkVolume -= suitcaseVolume;
                if (planeTrunkVolume < 0)
                {
                    suitcaseCount--;
                    Console.WriteLine("No more space!");
                    Console.WriteLine($"Statistic: {suitcaseCount} suitcases loaded.");
                    Environment.Exit(0);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Congratulations! All suitcases are loaded!");
            Console.WriteLine($"Statistic: {suitcaseCount} suitcases loaded.");
        }
    }
}
