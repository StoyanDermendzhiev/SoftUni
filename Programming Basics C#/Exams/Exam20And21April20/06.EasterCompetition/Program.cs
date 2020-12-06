using System;

namespace _06.EasterCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterBreadNumber = int.Parse(Console.ReadLine());
            int maxPoints = int.MinValue;
            string bestChef = "";

            for (int easterBread = 1; easterBread <= easterBreadNumber; easterBread++)
            {
                string bakerName = Console.ReadLine();
                string input = Console.ReadLine();
                int pointCount = 0;
                while (input != "Stop")
                {
                    int grade = int.Parse(input);
                    pointCount += grade;
                    input = Console.ReadLine();
                }
                Console.WriteLine($"{bakerName} has {pointCount} points.");
                if (maxPoints < pointCount)
                {
                    maxPoints = pointCount;
                    bestChef = bakerName;
                    Console.WriteLine($"{bestChef} is the new number 1!");
                }
            }
            Console.WriteLine($"{bestChef} won competition with {maxPoints} points!");
        }
    }
}
