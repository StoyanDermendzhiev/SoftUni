using System;
using System.Collections.Generic;
using System.Text;

namespace _04.PizzaCalories
{
    public class Pizza
    {
        private const int nameMinLength = 1;
        private const int nameMaxLength = 15;
        private const int maxNumberOfToppings = 10;
        
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name, Dough dough)
        {
            Name = name;
            this.dough = dough;
            this.toppings = new List<Topping>();
        }

        public string Name
        {
            get => name;
            private set
            {
                if (value.Length < nameMinLength || value.Length > nameMaxLength)
                {
                    throw new ArgumentException($"Pizza name should be between {nameMinLength} and {nameMaxLength} symbols.");
                }

                name = value;
            }
        }

        public int GetNumberOfToppings() => toppings.Count;

        public double GetTotalCalories()
        {
            double totalCalories = 0;

            foreach (Topping topping in toppings)
            {
                totalCalories += topping.GetTotalCalories();
            }

            totalCalories += dough.GetTotalCalories();

            return totalCalories;
        }

        public void AddTopping(Topping topping)
        {
            if (toppings.Count == maxNumberOfToppings)
            {
                throw new InvalidOperationException($"Number of toppings should be in range [0..{maxNumberOfToppings}].");
            }

            toppings.Add(topping);
        }
    }
}
