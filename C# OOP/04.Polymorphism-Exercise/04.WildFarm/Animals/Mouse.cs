using System.Collections.Generic;
using _04.WildFarm.Foods;

namespace _04.WildFarm.Animals
{
    public class Mouse : Mammal
    {
        private const double baseWeightModifier = 0.10;
        private static HashSet<string> allowedFoods = new HashSet<string>
        {
            nameof(Vegetable),
            nameof(Fruit)
        };

        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, allowedFoods, baseWeightModifier, livingRegion)
        {
        }

        public override string ProduceSound()
        {
            return "Squeak";
        }
    }
}
