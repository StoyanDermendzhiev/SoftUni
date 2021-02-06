using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryOpenning
{
    public class Bakery
    {
        private List<Employee> data;

        public Bakery(string name, int capacity)
        {
            data = new List<Employee>(capacity);
            Name = name;
            Capacity = capacity;
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count => data.Count;

        public void Add(Employee employee)
        {
            if (data.Count < Capacity)
            {
                data.Add(employee);
            }
        }

        public bool Remove(string name)
        {
            Employee currEmployee = data.Find(e => e.Name == name);

            if (currEmployee != null)
            {
                data.Remove(currEmployee);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Employee GetOldestEmployee()
        {
            Employee oldestEmployee = data.OrderByDescending(e => e.Age).FirstOrDefault();

            return oldestEmployee;
        }

        public Employee GetEmployee(string name)
        {
            return data.Find(e => e.Name == name);
        }

        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Employees working at Bakery {Name}:");

            foreach (var employee in data)
            {
                sb.AppendLine(employee.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
