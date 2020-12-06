using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OldestFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] inputLine = Console.ReadLine().Split();
                string name = inputLine[0];
                int age = int.Parse(inputLine[1]);
                                
                family.AddMember(name, age);
            }

            Person oldestMember = family.GetOldestMember(family);

            Console.WriteLine(oldestMember);
        }
    }

    class Family
    {
        public Family()
        {
            FamilyMembers = new List<Person>();
        }

        public void AddMember(string name, int age)
        {
            FamilyMembers.Add(new Person(name, age));
        }

        public Person GetOldestMember(Family family)
        {
            return FamilyMembers.OrderByDescending(x => x.Age).First();
        }

        public List<Person> FamilyMembers { get; set; }
    }

    class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} {Age}";
        }
    }
}
