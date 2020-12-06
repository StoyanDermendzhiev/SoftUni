using System;

namespace _08.GraduationPt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int schoolClass = 1;
            int count = 0;
            double averageGrade = 0;
            while (schoolClass <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade < 4.00)
                {

                    count += 1;
                    if (count == 2)
                    {
                        Console.WriteLine($"{studentName} has been excluded at {schoolClass} grade");
                        break;
                    }
                    schoolClass -= count;
                }
                averageGrade += grade;
                schoolClass += 1;
            }
            averageGrade = averageGrade / 12;
            if (count != 2)
            {
                Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:f2}");
            }
        }
    }
}
