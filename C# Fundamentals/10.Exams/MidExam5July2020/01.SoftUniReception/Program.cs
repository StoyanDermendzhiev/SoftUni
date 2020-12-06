using System;

namespace _01.SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int hoursCount = 0;

            int allEmployee = firstEmployee + secondEmployee + thirdEmployee;

            while (students > 0)
            {
                hoursCount++;
                if (hoursCount % 4 == 0)
                {
                    continue;
                }

                students -= allEmployee;
            }

            Console.WriteLine($"Time needed: {hoursCount}h.");
        }
    }
}
