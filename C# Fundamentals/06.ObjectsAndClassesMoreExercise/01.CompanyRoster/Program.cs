using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CompanyRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesOfEmployees = int.Parse(Console.ReadLine());

            List<Department> departments = new List<Department>();

            for (int i = 0; i < linesOfEmployees; i++)
            {
                string[] inputLine = Console.ReadLine().Split();
                string name = inputLine[0];
                double salary = double.Parse(inputLine[1]);
                string department = inputLine[2];

                if (!departments.Any(x => x.Name == department))
                {
                    departments.Add(new Department(department));
                }

                departments.Find(x => x.Name == department).AddEmployee(name, salary);
            }

            Department bestDepartment = departments.OrderByDescending(x => x.TotalSalaries / x.Employees.Count()).First();

            Console.WriteLine($"Highest Average Salary: {bestDepartment.Name}");

            foreach (Employee currentEmployee in bestDepartment.Employees.OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{currentEmployee.Name} {currentEmployee.Salary:f2}");
            }
        }
    }
    class Employee
    {
        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public string Name { get; set; }
        public double Salary { get; set; }
    }

    class Department
    {
        public void AddEmployee(string name, double salary)
        {
            TotalSalaries += salary;
            Employees.Add(new Employee(name, salary));
        }

        public Department(string name)
        {
            Name = name;
            Employees = new List<Employee>();
        }

        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
        public double TotalSalaries { get; set; }
    }
}
