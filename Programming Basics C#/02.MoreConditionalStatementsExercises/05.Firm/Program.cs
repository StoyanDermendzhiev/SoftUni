using System;

namespace _05.Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int hoursNeeded = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int bestworkers = int.Parse(Console.ReadLine());
            //Calculations
            double realDays = days * 0.9;
            double workingHours = Math.Floor(8 * realDays + bestworkers*days*2);
            if (workingHours >= hoursNeeded)
            {
                double hoursLeft = workingHours - hoursNeeded;
                Console.WriteLine($"Yes!{hoursLeft} hours left.");
            }
            else
            {
                double moreHours = hoursNeeded - workingHours;
                Console.WriteLine($"Not enough time!{moreHours} hours needed.");
            }
        }
    }
}
