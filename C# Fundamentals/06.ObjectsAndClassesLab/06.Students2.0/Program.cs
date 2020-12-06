using System;
using System.Collections.Generic;

namespace _05.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] currentLine = line.Split();

                string firstName = currentLine[0];
                string lastName = currentLine[1];
                int age = int.Parse(currentLine[2]);
                string hometown = currentLine[3];

                if (IsStudentExisting(students, firstName, lastName))
                {
                    Student currentStudent = GetStudent(students, firstName, lastName);

                    currentStudent.FirstName = firstName;
                    currentStudent.LastName = lastName;
                    currentStudent.Age = age;
                    currentStudent.Hometown = hometown;
                }
                else
                {
                    Student currentStudent = new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        Hometown = hometown
                    };

                    students.Add(currentStudent);
                }

                line = Console.ReadLine();
            }

            string filterTown = Console.ReadLine();

            foreach (Student currentStudent in students)
            {
                if (currentStudent.Hometown == filterTown)
                {
                    Console.WriteLine($"{currentStudent.FirstName} {currentStudent.LastName} is {currentStudent.Age} years old.");
                }
            }
        }

        private static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student existingStudent = null;

            foreach (Student currentStudent in students)
            {
                if (currentStudent.FirstName == firstName && currentStudent.LastName == lastName)
                {
                    existingStudent = currentStudent;
                }
            }

            return existingStudent;
        }

        static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
        {
            foreach (Student currentStudent in students)
            {
                if (currentStudent.FirstName == firstName && currentStudent.LastName == lastName)
                {
                    return true;
                }
            }

            return false;
        }
        class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string Hometown { get; set; }
        }
    }
}
