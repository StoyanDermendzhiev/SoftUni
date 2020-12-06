using System;

namespace _02.MountainRun
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double worldRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeForMeter = double.Parse(Console.ReadLine());
            //Calculations
            double slowing = Math.Floor(distance / 50) * 30;
            double totalTime = distance * timeForMeter + slowing;
            if (totalTime<worldRecord)
            {
                Console.WriteLine($"Yes! The new record is {totalTime:f2} seconds.");
            }
            else
            {
                double timeNeeded = totalTime - worldRecord;
                Console.WriteLine($"No! He was {timeNeeded:f2} seconds slower.");
            }
        }
    }
}
