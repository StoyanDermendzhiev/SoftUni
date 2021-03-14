using System.Collections.Generic;
using _04.WildFarm.Foods;

namespace _04.WildFarm.Animals
{
    public class Owl : Bird
    {
        private const double baseWeightModifier = 0.25;
        private static HashSet<string> allowedFoods = new HashSet<string> {nameof(Meat)};


        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, allowedFoods, baseWeightModifier, wingSize)
        {
        }
        
        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }
    }
}
