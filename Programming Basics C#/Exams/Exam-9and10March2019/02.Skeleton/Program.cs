using System;

namespace _02.Skeleton
{
    class Program
    {
        static void Main(string[] args)
        {
            int controlMinutes = int.Parse(Console.ReadLine());
            int controlSeconds = int.Parse(Console.ReadLine());
            double lengthInMeters = double.Parse(Console.ReadLine());
            int secondsFor100Meters = int.Parse(Console.ReadLine());

            double controlInSeconds = controlMinutes * 60 + controlSeconds;
            double timeInSeconds = lengthInMeters / 100 * secondsFor100Meters;
            double slowingTimeInSeconds = lengthInMeters / 120 * 2.5;
            timeInSeconds -= slowingTimeInSeconds;

            if (timeInSeconds <= controlInSeconds)
            {
                Console.WriteLine($"Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {timeInSeconds:f3}.");
            }
            else
            {
                Console.WriteLine($"No, Marin failed! He was {timeInSeconds - controlInSeconds:f3} second slower.");
            }
        }
    }
}
