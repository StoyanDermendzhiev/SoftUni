using System;
using System.Collections.Generic;
using _04.WildFarm.Foods;

namespace _04.WildFarm.Animals
{
    public abstract class Animal
    {
        protected Animal(
            string name, 
            double weight, 
            HashSet<string> allowedFoods,
            double weightModifier)
        {
            Name = name;
            Weight = weight;
            AllowedFoods = allowedFoods;
            WeightModifier = weightModifier;
        }

        private HashSet<string> AllowedFoods { get; set; }

        private double WeightModifier { get; set; }

        public string Name { get; private set; }

        public double Weight { get; private set; }

        protected int FoodEaten { get; private set; }

        public abstract string ProduceSound();

        public void Eat(Food food)
        {
            string foodType = food.GetType().Name;

            if (!AllowedFoods.Contains(foodType))
            {
                throw new InvalidOperationException($"{GetType().Name} does not eat {foodType}!");
            }

            FoodEaten += food.Quantity;

            Weight += WeightModifier * food.Quantity;
        }
    }
}
