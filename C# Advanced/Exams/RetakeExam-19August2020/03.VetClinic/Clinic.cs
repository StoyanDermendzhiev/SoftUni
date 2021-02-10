using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        private List<Pet> pets;

        public Clinic(int capacity)
        {
            Capacity = capacity;
            pets = new List<Pet>();
        }

        public int Capacity { get; set; }

        public int Count => pets.Count;

        public void Add(Pet pet)
        {
            if (pets.Count < Capacity)
            {
                pets.Add(pet);
            }
        }

        public bool Remove(string name)
        {
            Pet removedPet = pets.Find(p => p.Name == name);

            if (removedPet != null)
            {
                pets.Remove(removedPet);
                return true;
            }

            return false;
        }

        public Pet GetPet(string name, string owner)
        {
            return pets.FindAll(p => p.Owner == owner)
                       .Find(p => p.Name == name);
        }

        public Pet GetOldestPet()
        {
            return pets.OrderByDescending(p => p.Age).FirstOrDefault();
        }

        public string GetStatistics()
        {
            var sb = new StringBuilder();
            sb.AppendLine("The clinic has the following patients:");

            foreach (var pet in pets)
            {
                sb.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }

            return sb.ToString().Trim();
        }
    }
}
