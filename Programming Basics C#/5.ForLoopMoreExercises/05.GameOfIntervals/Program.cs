using System;

namespace _05.GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int moves = int.Parse(Console.ReadLine());
            double finalResult = 0;
            double numberFrom0To9 = 0;
            double numberFrom10To19 = 0;
            double numberFrom20To29 = 0;
            double numberFrom30To39 = 0;
            double numberFrom40To50 = 0;
            double invalidNumbers = 0;
            for (int i = 1; i <= moves; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number >= 0 && number <= 9)
                {
                    numberFrom0To9 += 1;
                    finalResult += 0.2 * number;
                }
                else if (number >= 10 && number <= 19)
                {
                    numberFrom10To19 += 1;
                    finalResult += 0.3 * number;
                }
                else if (number >= 20 && number <= 29)
                {
                    numberFrom20To29 += 1;
                    finalResult += 0.4 * number;
                }
                else if (number >= 30 && number <= 39)
                {
                    numberFrom30To39 += 1;
                    finalResult += 50;
                }
                else if (number >= 40 && number <= 50)
                {
                    numberFrom40To50 += 1;
                    finalResult += 100;
                }
                else
                {
                    invalidNumbers += 1;
                    finalResult /= 2;
                }
            }
            numberFrom0To9 = numberFrom0To9 / moves * 100;
            numberFrom10To19 = numberFrom10To19 / moves * 100;
            numberFrom20To29 = numberFrom20To29 / moves * 100;
            numberFrom30To39 = numberFrom30To39 / moves * 100;
            numberFrom40To50 = numberFrom40To50 / moves * 100;
            invalidNumbers = invalidNumbers / moves * 100;
            Console.WriteLine($"{finalResult:f2}");
            Console.WriteLine($"From 0 to 9: {numberFrom0To9:f2}%");
            Console.WriteLine($"From 10 to 19: {numberFrom10To19:f2}%");
            Console.WriteLine($"From 20 to 29: {numberFrom20To29:f2}%");
            Console.WriteLine($"From 30 to 39: {numberFrom30To39:f2}%");
            Console.WriteLine($"From 40 to 50: {numberFrom40To50:f2}%");
            Console.WriteLine($"Invalid numbers: {invalidNumbers:f2}%");
        }
    }
}
