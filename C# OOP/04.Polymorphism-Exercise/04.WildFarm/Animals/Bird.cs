using System.Collections.Generic;

namespace _04.WildFarm.Animals
{
    public abstract class Bird : Animal
    {
        protected Bird(
            string name, 
            double weight, 
            HashSet<string> allowedFoods, 
            double weightModifier,
            double wingSize) 
            : base(name, weight, allowedFoods, weightModifier)
        {
            WingSize = wingSize;
        }

        public double WingSize { get; private set; }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
        }
    }
}
