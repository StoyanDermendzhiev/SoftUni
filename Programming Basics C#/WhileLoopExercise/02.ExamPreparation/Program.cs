using System;

namespace _02.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int enoughPoorGrade = int.Parse(Console.ReadLine());
            string problemName = Console.ReadLine();
            int grade = 0;
            int poorGradeCount = 0;
            int gradeCount = 0;
            int totalGrade = 0;
            string newProblemName = "";
            while (problemName != "Enough")
            {
                grade = int.Parse(Console.ReadLine());
                newProblemName = problemName;
                if (grade <= 4)
                {
                    poorGradeCount++;
                    gradeCount--;
                    if (poorGradeCount == enoughPoorGrade)
                    {
                        Console.WriteLine($"You need a break, {enoughPoorGrade} poor grades.");
                        Environment.Exit(0);
                    }
                }
                gradeCount++;
                totalGrade += grade;
                problemName = Console.ReadLine();
                
            }
            double averageGrade = 1.0 * totalGrade / (poorGradeCount + gradeCount);
            Console.WriteLine($"Average score: {averageGrade:f2}");
            Console.WriteLine($"Number of problems: {poorGradeCount+gradeCount}");
            Console.WriteLine($"Last problem: {newProblemName}");
        }
    }
}
