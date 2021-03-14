using System.Collections.Generic;
using _04.WildFarm.Foods;

namespace _04.WildFarm.Animals
{
    public class Tiger : Feline
    {
        private const double baseWeightModifier = 1.00;
        private static HashSet<string> allowedFoods = new HashSet<string>
        {
            nameof(Meat)
        };

        public Tiger(string name, double weight, string livingRegion, string breed)
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
            return "ROAR!!!";
        }
    }
}
