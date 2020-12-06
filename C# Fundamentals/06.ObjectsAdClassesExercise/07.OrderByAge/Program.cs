using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Person> personList = new List<Person>();

            while (input != "End")
            {
                string[] line = input.Split();
                string name = line[0];
                string id = line[1];
                int age = int.Parse(line[2]);

                Person currentPerson = new Person(name, id, age);

                personList.Add(currentPerson);

                input = Console.ReadLine();
            }

            personList = personList.OrderBy(x => x.Age).ToList();

            foreach (Person currentPerson in personList)
            {
                Console.WriteLine(currentPerson.ToString());
            }
        }
    }
    class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
}
