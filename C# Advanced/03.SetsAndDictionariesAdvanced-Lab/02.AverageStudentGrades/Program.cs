using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> studentsGrades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] studentInfo = Console.ReadLine().Split();
                string studentName = studentInfo[0];
                decimal grade = decimal.Parse(studentInfo[1]);

                if (!studentsGrades.ContainsKey(studentName))
                {
                    studentsGrades.Add(studentName, new List<decimal>());
                }

                studentsGrades[studentName].Add(grade);
            }

            foreach (var student in studentsGrades)
            {
                Console.Write($"{student.Key} -> ");

                foreach (var grade in student.Value)
                {
                    Console.Write($"{grade:f2} ");
                }

                Console.WriteLine($"(avg: {student.Value.Average():f2})");
            }
        }
    }
}
