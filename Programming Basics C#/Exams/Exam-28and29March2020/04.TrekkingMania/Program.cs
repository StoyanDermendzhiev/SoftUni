using System;

namespace _04.TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGroups = int.Parse(Console.ReadLine());
            double climbersOfMusala = 0;
            double climbersOfMontblan = 0;
            double climbersOfKilimanjaro = 0;
            double climbersOfK2 = 0;
            double climbersOfEverest = 0;
            double allClimbers = 0;
            for (int i = 1; i <= numberOfGroups; i++)
            {
                int climbersPerGroup = int.Parse(Console.ReadLine());
                if (climbersPerGroup <= 5)
                {
                    climbersOfMusala += climbersPerGroup;
                }
                else if (climbersPerGroup >=6 && climbersPerGroup <= 12)
                {
                    climbersOfMontblan += climbersPerGroup;
                }
                else if (climbersPerGroup >= 13 && climbersPerGroup <= 25)
                {
                    climbersOfKilimanjaro += climbersPerGroup;
                }
                else if (climbersPerGroup >= 26 && climbersPerGroup <= 40)
                {
                    climbersOfK2 += climbersPerGroup;
                }
                else
                {
                    climbersOfEverest += climbersPerGroup;
                }
            }
            allClimbers = climbersOfMusala + climbersOfMontblan + climbersOfKilimanjaro + climbersOfK2 + climbersOfEverest;
            climbersOfMusala = climbersOfMusala / allClimbers * 100;
            climbersOfMontblan = climbersOfMontblan / allClimbers * 100;
            climbersOfKilimanjaro = climbersOfKilimanjaro / allClimbers * 100;
            climbersOfK2 = climbersOfK2 / allClimbers * 100;
            climbersOfEverest = climbersOfEverest / allClimbers * 100;
            Console.WriteLine($"{climbersOfMusala:f2}%");
            Console.WriteLine($"{climbersOfMontblan:f2}%");
            Console.WriteLine($"{climbersOfKilimanjaro:f2}%");
            Console.WriteLine($"{climbersOfK2:f2}%");
            Console.WriteLine($"{climbersOfEverest:f2}%");
        }
    }
}
