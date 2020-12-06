using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < countOfStudents; i++)
            {
                string[] student = Console.ReadLine().Split();
                Student currentStudent = new Student(student[0], student[1], double.Parse(student[2]));
                students.Add(currentStudent);
            }

            students = students.OrderBy(x => x.Grade).ToList();
            students.Reverse();

            foreach (Student currentStudent in students)
            {
                Console.WriteLine(currentStudent);
            }
        }
    }
    class Student
    {
        public Student(string firstName, string secondName, double grade)
        {
            FirstName = firstName;
            SecondName = secondName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName:f2} {SecondName:f2}: {Grade:f2}";
        }
    }
}
