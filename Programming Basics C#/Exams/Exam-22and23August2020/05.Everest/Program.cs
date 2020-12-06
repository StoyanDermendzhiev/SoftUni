using System;
using System.Xml.Schema;

namespace _05.Everest
{
    class Program
    {
        static void Main(string[] args)
        {
            string sleep = Console.ReadLine();

            int dayCount = 1;
            int totalMetersClimbed = 5364;

            while (sleep != "END")
            {
                int metersClimbed = int.Parse(Console.ReadLine());
                if (sleep == "Yes")
                {
                    dayCount++;
                }
                if (dayCount > 5)
                {
                    Console.WriteLine("Failed!");
                    Console.WriteLine($"{totalMetersClimbed}");
                    return;
                }
                totalMetersClimbed += metersClimbed;
                if (totalMetersClimbed >= 8848)
                {
                    Console.WriteLine($"Goal reached for {dayCount} days!");
                    return;
                }
                sleep = Console.ReadLine();
            }

            Console.WriteLine("Failed!");
            Console.WriteLine($"{totalMetersClimbed}");
        }
    }
}
