using System;
using System.ComponentModel;

namespace _01.SeriesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string seriesName = Console.ReadLine();
            int seasonNumber = int.Parse(Console.ReadLine());
            int episodeNumber = int.Parse(Console.ReadLine());
            double episodeTime = double.Parse(Console.ReadLine());

            double totalTime = seasonNumber * episodeNumber * episodeTime;
            totalTime += totalTime * 0.20 + seasonNumber * 10;

            Console.WriteLine($"Total time needed to watch the {seriesName} series is {totalTime} minutes.");
        }
    }
}
