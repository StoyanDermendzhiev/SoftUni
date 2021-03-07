﻿using System;
using _07.MilitaryElite.Contracts;

namespace _07.MilitaryElite.Models
{
    public class Spy : Soldier, ISpy
    {
        public Spy(string id, string firstName, string lastName, int codeNumber) 
            : base(id, firstName, lastName)
        {
            CodeNumber = codeNumber;
        }

        public int CodeNumber { get; private set; }

        public override string ToString()
        {
            return base.ToString() + 
                   Environment.NewLine +
                   $"Code Number: {CodeNumber}";
        }
    }
}
