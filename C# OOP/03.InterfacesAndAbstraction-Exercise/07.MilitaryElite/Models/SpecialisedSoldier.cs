using System;
using _07.MilitaryElite.Contracts;
using _07.MilitaryElite.Enums;

namespace _07.MilitaryElite.Models
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        protected SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, Corps corps) 
            : base(id, firstName, lastName, salary)
        {
            Corps = corps;
        }

        public Corps Corps { get; private set; }

        public override string ToString()
        {
            return base.ToString() +
                   Environment.NewLine +
                   $"Corps: {Corps}";
        }
    }
}
