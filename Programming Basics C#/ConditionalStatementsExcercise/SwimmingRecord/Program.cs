using System;

namespace SwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double sec = double.Parse(Console.ReadLine());
            double slow = (Math.Floor(distance / 15)) * 12.5;
            double time = distance * sec + slow;
            if (time<record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {time:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {(time - record):F2} seconds slower.");
            }
        }
    }
}
