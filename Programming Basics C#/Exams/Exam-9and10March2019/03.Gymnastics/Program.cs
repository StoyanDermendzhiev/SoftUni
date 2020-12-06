using System;

namespace _03.Gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string device = Console.ReadLine();
            double difficulty = 0;
            double execution = 0;
            if (device == "ribbon")
            {
                switch (country)
                {
                    case "Russia":
                        difficulty = 9.100;
                        execution = 9.400;
                        break;
                    case "Bulgaria":
                        difficulty = 9.600;
                        execution = 9.400;
                        break;
                    case "Italy":
                        difficulty = 9.200;
                        execution = 9.500;
                        break;
                }
            }
            else if (device == "hoop")
            {
                switch (country)
                {
                    case "Russia":
                        difficulty = 9.300;
                        execution = 9.800;
                        break;
                    case "Bulgaria":
                        difficulty = 9.550;
                        execution = 9.750;
                        break;
                    case "Italy":
                        difficulty = 9.450;
                        execution = 9.350;
                        break;
                }
            }
            else if (device == "rope")
            {
                switch (country)
                {
                    case "Russia":
                        difficulty = 9.600;
                        execution = 9.000;
                        break;
                    case "Bulgaria":
                        difficulty = 9.500;
                        execution = 9.400;
                        break;
                    case "Italy":
                        difficulty = 9.700;
                        execution = 9.150;
                        break;
                }
            }
            double totalPoints = difficulty + execution;
            double percentNeeded = (20 - totalPoints) / 20 * 100;

            Console.WriteLine($"The team of {country} get {totalPoints:f3} on {device}.");
            Console.WriteLine($"{percentNeeded:f2}%");
        }
    }
}
