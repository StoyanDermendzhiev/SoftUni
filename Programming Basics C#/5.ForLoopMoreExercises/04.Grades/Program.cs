using System;

namespace _04.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsNumber = int.Parse(Console.ReadLine());
            double grade2Studenst = 0;
            double grade3Studenst = 0;
            double grade4Studenst = 0;
            double topStudenst = 0;
            double averageGrade = 0;
            for (int i = 1; i <= studentsNumber; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 2.00 && grade <= 2.99)
                {
                    grade2Studenst += 1;
                }
                else if (grade >= 3.00 && grade <= 3.99)
                {
                    grade3Studenst += 1;
                }
                else if (grade >= 4.00 && grade <= 4.99)
                {
                    grade4Studenst += 1;
                }
                else if (grade >= 5.00)
                {
                    topStudenst += 1;
                }
                averageGrade += grade;
            }
            topStudenst = topStudenst / studentsNumber * 100;
            grade4Studenst = grade4Studenst / studentsNumber * 100;
            grade3Studenst = grade3Studenst / studentsNumber * 100;
            grade2Studenst = grade2Studenst / studentsNumber * 100;
            averageGrade = averageGrade / studentsNumber;
            Console.WriteLine($"Top students: {topStudenst:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {grade4Studenst:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {grade3Studenst:f2}%");
            Console.WriteLine($"Fail: {grade2Studenst:f2}%");
            Console.WriteLine($"Average: {averageGrade:f2}");
        }
    }
}
