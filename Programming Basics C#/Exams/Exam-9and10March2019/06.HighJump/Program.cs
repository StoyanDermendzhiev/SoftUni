using System;

namespace _06.HighJump
{
    class Program
    {
        static void Main(string[] args)
        {
            int goalHeight = int.Parse(Console.ReadLine());
            int height = goalHeight - 30;
            int count = 0;

            for (int i = height; i <= goalHeight; i += 5)
            {
                int tihomirHeight = int.Parse(Console.ReadLine());
                int failCount = 0;
                while (tihomirHeight <= i)
                {
                    count++;
                    failCount++;
                    if (failCount == 3)
                    {
                        Console.WriteLine($"Tihomir failed at {i}cm after {count} jumps.");
                        return;
                    }

                    tihomirHeight = int.Parse(Console.ReadLine());
                }
                count++;
            }
            Console.WriteLine($"Tihomir succeeded, he jumped over {goalHeight}cm after {count} jumps.");
        }
    }
}

