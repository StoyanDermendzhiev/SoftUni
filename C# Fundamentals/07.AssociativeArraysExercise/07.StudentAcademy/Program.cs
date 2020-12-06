using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsNumber = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentsGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < studentsNumber; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (studentsGrades.ContainsKey(studentName))
                {
                    studentsGrades[studentName].Add(grade);
                }
                else
                {
                    studentsGrades.Add(studentName, new List<double>());
                    studentsGrades[studentName].Add(grade);
                }
            }

            Dictionary<string, double> averageGrades = new Dictionary<string, double>();

            foreach (var currentStudent in studentsGrades)
            {
                double averageGrade = currentStudent.Value.Sum() / currentStudent.Value.Count;
                averageGrades.Add(currentStudent.Key, averageGrade);
            }

            averageGrades = averageGrades.OrderByDescending(x => x.Value)
                                         .Where(x => x.Value >= 4.50)
                                         .ToDictionary(x => x.Key, x => x.Value);

            foreach (var student in averageGrades)
            {
                Console.WriteLine($"{student.Key} -> {student.Value:f2}");
            }
        }
    }
}
