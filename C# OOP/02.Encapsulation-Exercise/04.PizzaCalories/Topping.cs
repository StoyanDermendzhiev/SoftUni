using System;
using System.Collections.Generic;
using System.Text;

namespace _04.PizzaCalories
{
    public class Topping
    {
        private const double caloriesPerGram = 2;
        private const string invalidWeight = "{0} weight should be in the range [1..50].";
        private const string invalidTopping = "Cannot place {0} on top of your pizza.";

        private string type;
        private int weight;

        public Topping(string type, int weight)
        {
            Type = type;
            Weight = weight;
        }

        public string Type
        {
            get => type;
            private set
            {
                string lowerType = value.ToLower();

                if (lowerType != "meat" &&
                    lowerType != "veggies" &&
                    lowerType != "cheese" &&
                    lowerType != "sauce")
                {
                    throw new ArgumentException(string.Format(invalidTopping, value));
                }

                type = value;
            }
        }

        public int Weight
        {
            get => weight;
            private set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException(String.Format(invalidWeight, type));
                }

                weight = value;
            }
        }

        public double GetCaloriesPerGram()
        {
            double value = caloriesPerGram;
            string lowerType = type.ToLower();

            switch (lowerType)
            {
                case "meat":
                    value *= 1.2;
                    break;
                case "veggies":
                    value *= 0.8;
                    break;
                case "cheese":
                    value *= 1.1;
                    break;
                case "sauce":
                    value *= 0.9;
                    break;
            }

            return value;
        }

        public double GetTotalCalories()
        {
            return GetCaloriesPerGram() * Weight;
        }
    }
}
