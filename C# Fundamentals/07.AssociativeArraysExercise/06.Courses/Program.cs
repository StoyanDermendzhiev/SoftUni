using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while (inputLine != "end")
            {
                string[] inputCourse = inputLine.Split(" : ");
                string courseName = inputCourse[0];
                string studentName = inputCourse[1];

                if (courses.ContainsKey(courseName))
                {
                    courses[courseName].Add(studentName);
                }
                else
                {
                    courses.Add(courseName, new List<string>());
                    courses[courseName].Add(studentName);
                }

                inputLine = Console.ReadLine();
            }

            courses = courses.OrderByDescending(x => x.Value.Count)
                             .ToDictionary(x => x.Key, x => x.Value);

            foreach (var currentCourse in courses)
            {
                StringBuilder sb = new StringBuilder();

                Console.WriteLine($"{currentCourse.Key}: {currentCourse.Value.Count}");

                currentCourse.Value.Sort();

                foreach (string currentStudent in currentCourse.Value)
                {
                    sb.AppendLine($"-- {currentStudent}");
                }

                Console.WriteLine(sb.ToString().Trim());
            }
        }
    }
}
