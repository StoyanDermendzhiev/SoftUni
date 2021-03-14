using System.Collections.Generic;
using _04.WildFarm.Foods;

namespace _04.WildFarm.Animals
{
    public class Cat : Feline
    {
        private const double baseWeightModifier = 0.30;
        private static HashSet<string> allowedFoods = new HashSet<string>
        {
            nameof(Vegetable),
            nameof(Meat)
        };

        public Cat(string name, double weight, string livingRegion, string breed)
            : base(
                name,
                weight,
                allowedFoods, 
                baseWeightModifier, 
                livingRegion,
                breed)
        {
        }
        
        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
