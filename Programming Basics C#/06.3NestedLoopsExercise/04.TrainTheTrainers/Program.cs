using System;

namespace _04.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int juryNumber = int.Parse(Console.ReadLine());
            string presentationName = Console.ReadLine();
            double averagePresentationGrade = 0;
            int presentationCount = 0;
            double averageGrade = 0;
            while (presentationName != "Finish")
            {
                presentationCount++;
                double totalGrades = 0;
                for (int i = 1; i <= juryNumber; i++)
                {
                    
                    double grades = double.Parse(Console.ReadLine());
                    totalGrades += grades;
                }
                averagePresentationGrade = totalGrades / juryNumber;
                averageGrade += averagePresentationGrade;
                Console.WriteLine($"{presentationName} - {averagePresentationGrade:f2}.");
                presentationName = Console.ReadLine();
            }
            averageGrade = averageGrade / presentationCount;
            Console.WriteLine($"Student's final assessment is {averageGrade:f2}.");
        }
    }
}
