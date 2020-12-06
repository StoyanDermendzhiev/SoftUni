using System;

namespace _04.Renovation
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int percentNotForPaint = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            double areaForPaint = Math.Ceiling(height * lenght * 4 - 4.0 * height * lenght * percentNotForPaint / 100);

            while (input != "Tired!")
            {
                int paint = int.Parse(input);
                areaForPaint -= paint;
                if (areaForPaint < 0)
                {
                    Console.WriteLine($"All walls are painted and you have {Math.Abs(areaForPaint)} l paint left!");
                    return;
                }
                else if (areaForPaint == 0)
                {
                    Console.WriteLine("All walls are painted! Great job, Pesho!");
                    return;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"{areaForPaint} quadratic m left.");
        }
    }
}
