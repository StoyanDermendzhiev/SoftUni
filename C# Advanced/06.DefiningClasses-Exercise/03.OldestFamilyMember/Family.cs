using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        public Family(List<Person> people)
        {
            People = new List<Person>();
        }

        public List<Person> People { get; set; }

        public void AddMember(Person person)
        {
            People.Add(person);
        }

        public Person GetOldestMember()
        {
            Person oldestMember = People.OrderByDescending(p => p.Age)
                                        .FirstOrDefault();

            return oldestMember;
        }
    }
}
