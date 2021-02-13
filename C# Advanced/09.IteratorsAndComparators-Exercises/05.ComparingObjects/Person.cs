using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _05.ComparingObjects
{
    public class Person : IComparable<Person>
    {
        private string name;
        private int age;
        private string town;

        public Person(string name, int age, string town)
        {
            this.name = name;
            this.age = age;
            this.town = town;
        }

        public int CompareTo(Person other)
        {
            bool isEqual = this.name == other.name &&
                           this.age == other.age &&
                           this.town == other.town;

            if (isEqual)
            {
                return 0;
            }

            return 1;
        }
    }
}
