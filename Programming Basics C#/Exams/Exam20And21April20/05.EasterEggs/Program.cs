using System;

namespace _05.EasterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int paintedEggsNumber = int.Parse(Console.ReadLine());
            int redCount = 0;
            int orangeCount = 0;
            int blueCount = 0;
            int greenCount = 0;
            int maxEggNumber = int.MinValue;
            string maxEggColor = "";
            for (int egg = 1; egg <= paintedEggsNumber; egg++)
            {
                string eggColor = Console.ReadLine();
                switch (eggColor)
                {
                    case "red":
                        redCount++;
                        break;
                    case "orange":
                        orangeCount++;
                        break;
                    case "blue":
                        blueCount++;
                        break;
                    case "green":
                        greenCount++;
                        break;
                }
            }
            if (maxEggNumber < redCount)
            {
                maxEggNumber = redCount;
                maxEggColor = "red";
            }
            if (maxEggNumber < orangeCount)
            {
                maxEggNumber = orangeCount;
                maxEggColor = "orange";
            }
            if (maxEggNumber < blueCount)
            {
                maxEggNumber = blueCount;
                maxEggColor = "blue";
            }
            if (maxEggNumber < greenCount)
            {
                maxEggNumber = greenCount;
                maxEggColor = "green";
            }
            Console.WriteLine($"Red eggs: {redCount}");
            Console.WriteLine($"Orange eggs: {orangeCount}");
            Console.WriteLine($"Blue eggs: {blueCount}");
            Console.WriteLine($"Green eggs: {greenCount}");
            Console.WriteLine($"Max eggs: {maxEggNumber} -> {maxEggColor}");
        }
    }
}
