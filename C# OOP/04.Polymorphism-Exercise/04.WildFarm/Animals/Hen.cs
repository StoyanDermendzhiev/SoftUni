using System.Collections.Generic;
using _04.WildFarm.Foods;

namespace _04.WildFarm.Animals
{
    public class Hen : Bird
    {
        private const double baseWeightModifier = 0.35;
        private static HashSet<string> allowedFoods = new HashSet<string>
        {
            nameof(Meat), 
            nameof(Vegetable),
            nameof(Fruit),
            nameof(Seeds)
        };
        
        public Hen(string name, double weight, double wingSize)
            : base(name, weight, allowedFoods, baseWeightModifier, wingSize)
        {
        }

        public override string ProduceSound()
        {
            return "Cluck";
        }
    }
}
