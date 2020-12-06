using System;

namespace _9.Volleyball
{
    class Program
    {
        static int weekend = 48;
        static void Main(string[] args)
        {
            //Input
            string leapOrNormal = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            //Calculations
            double saturdayPlay = (weekend - h) * 3.0 / 4.0;
            double vacationPlay = p * 2.0 / 3.0;
            double totalPlay = vacationPlay + saturdayPlay + h;
            if (leapOrNormal == "leap")
            {
                totalPlay += totalPlay * 0.15;
            }
            Console.WriteLine(Math.Floor(totalPlay));
        }
    }
}
