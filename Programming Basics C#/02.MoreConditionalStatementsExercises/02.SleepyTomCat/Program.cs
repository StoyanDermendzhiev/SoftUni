using System;
using System.Runtime.CompilerServices;

namespace _02.SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Static data
            int workdaysPlay = 63;
            int holidaysPlay = 127;
            int yeardays = 365;
            int yearPlayLimit = 30000;
            //Input
            int holidays = int.Parse(Console.ReadLine());
            //Calculations
            int workdays = yeardays - holidays;
            int yearPlay = workdays * workdaysPlay + holidays * holidaysPlay;
            if (yearPlay > yearPlayLimit)
            {
                int overPlay = yearPlay - yearPlayLimit;
                int hours = overPlay / 60;
                int minutes = overPlay % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
            else
            {
                int lessPlay = yearPlayLimit - yearPlay;
                int hours = lessPlay / 60;
                int minutes = lessPlay % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
        }
    }
}
