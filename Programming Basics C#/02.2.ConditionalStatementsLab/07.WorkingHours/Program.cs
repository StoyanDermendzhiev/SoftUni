using System;

namespace _07.WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            //Calculations
            if ((hour >= 10 && hour <= 18) && (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday" || day == "Saturday"))
            {
                Console.WriteLine("open");
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
