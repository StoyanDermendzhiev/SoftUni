using System;

namespace _01.BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            int lecturesCount = int.Parse(Console.ReadLine());
            int initialBonus = int.Parse(Console.ReadLine());

            double maxBonus = 0;
            int studentMaxBonusAttendance = 0;

            for (int i = 0; i < studentsCount; i++)
            {
                int studentAttendance = int.Parse(Console.ReadLine());

                double totalBonus = studentAttendance / (double)lecturesCount * (5 + initialBonus);

                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    studentMaxBonusAttendance = studentAttendance;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {studentMaxBonusAttendance} lectures.");
        }
    }
}
