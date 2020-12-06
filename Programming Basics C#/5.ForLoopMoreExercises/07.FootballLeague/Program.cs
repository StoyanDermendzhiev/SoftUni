using System;

namespace _07.FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            int stadiumCapacity = int.Parse(Console.ReadLine());
            int totalFans = int.Parse(Console.ReadLine());
            double fansSectorA = 0;
            double fansSectorB = 0;
            double fansSectorV = 0;
            double fansSectorG = 0;
            double totalFansPercent = 0;
            for (int i = 1; i <= totalFans; i++)
            {
                char sector = char.Parse(Console.ReadLine());
                switch (sector)
                {
                    case 'A':
                        fansSectorA += 1;
                        break;
                    case 'B':
                        fansSectorB += 1;
                        break;
                    case 'V':
                        fansSectorV += 1;
                        break;
                    case 'G':
                        fansSectorG += 1;
                        break;
                }
            }
            fansSectorA = fansSectorA / totalFans * 100;
            fansSectorB = fansSectorB / totalFans * 100;
            fansSectorV = fansSectorV / totalFans * 100;
            fansSectorG = fansSectorG / totalFans * 100;
            totalFansPercent = 1.0 * totalFans / stadiumCapacity * 100;
            Console.WriteLine($"{fansSectorA:f2}%");
            Console.WriteLine($"{fansSectorB:f2}%");
            Console.WriteLine($"{fansSectorV:f2}%");
            Console.WriteLine($"{fansSectorG:f2}%");
            Console.WriteLine($"{totalFansPercent:f2}%");
        }
    }
}
