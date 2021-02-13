using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ComparingObjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] personData = command.Split();
                string name = personData[0];
                int age = int.Parse(personData[1]);
                string town = personData[2];

                Person person = new Person(name, age, town);
                people.Add(person);

                command = Console.ReadLine();
            }

            int n = int.Parse(Console.ReadLine());
            
            int matches = 0;
            int notMatches = 0;

            foreach (var person in people)
            {
                if (person.CompareTo(people[n-1]) == 0)
                {
                    matches++;
                }
                else
                {
                    notMatches++;
                }
            }

            if (matches <= 1)
            {
                Console.WriteLine("No matches");
                return;
            }

            Console.WriteLine($"{matches} {notMatches} {people.Count}");
        }
    }
}
