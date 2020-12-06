using System;

namespace _02.MovieDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = int.Parse(Console.ReadLine());
            int scenesNumber = int.Parse(Console.ReadLine());
            int sceneTime = int.Parse(Console.ReadLine());

            double timeNeeded = time * 0.15 + scenesNumber * sceneTime;

            if (timeNeeded <= time)
            {
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(time - timeNeeded)} minutes left!");
            }
            else
            {
                Console.WriteLine($"Time is up! To complete the movie you need {Math.Round(timeNeeded-time)} minutes.");
            }
        }
    }
}
