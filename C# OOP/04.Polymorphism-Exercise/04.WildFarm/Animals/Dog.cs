using System.Collections.Generic;
using _04.WildFarm.Foods;

namespace _04.WildFarm.Animals
{
    public class Dog : Mammal
    {
        private const double baseWeightModifier = 0.40;
        private static HashSet<string> allowedFoods = new HashSet<string>
        {
            nameof(Meat)
        };

        public Dog(string name, double weight, string livingRegion)
            : base(name, weight, allowedFoods, baseWeightModifier, livingRegion)
        {
        }

        public override string ProduceSound()
        {
            return "Woof!";
        }
    }
}
