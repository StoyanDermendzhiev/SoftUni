using System;
using System.Collections.Generic;
using System.Text;

namespace _04.PizzaCalories
{
    public class Dough
    {
        private const int minWeight = 1;
        private const int maxWeight = 200;
        private const double caloriesPerGram = 2;

        private string flourType;
        private string bakingTechnique;
        private int weight;

        public Dough(string flourType, string bakingTechnique, int weight)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Weight = weight;
        }
        public string FlourType
        {
            get => flourType;
            private set
            {
                if (!(value == "white" || value == "wholegrain"))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                flourType = value;
            }
        }

        public string BakingTechnique
        {
            get => bakingTechnique;
            private set
            {
                if (!(value == "crispy" ||
                    value == "chewy" ||
                    value == "homemade"))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                bakingTechnique = value;
            }
        }

        public int Weight
        {
            get => weight;
            private set
            {
                if (value < minWeight || value > maxWeight)
                {
                    throw new ArgumentException($"Dough weight should be in the range [{minWeight}..{maxWeight}].");
                }

                weight = value;
            }
        }

        public double GetCaloriesPerGram()
        {
            double value = caloriesPerGram;

            switch (flourType)
            {
                case "white":
                    value *= 1.5;
                    break;
                case "wholegrain":
                    value *= 1.0;
                    break;
            }

            switch (bakingTechnique)
            {
                case "crispy":
                    value *= 0.9;
                    break;
                case "chewy":
                    value *= 1.1;
                    break;
                case "homemade":
                    value *= 1.0;
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
