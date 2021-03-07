using _06.FoodShortage.Contracts;

namespace _06.FoodShortage.Models
{
    public class Rebel : ICitizen, IBuyer
    {
        private int food = 0;

        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
            Food = food;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Group { get; private set; }

        public int Food { get; private set; }

        public void BuyFood()
        {
            Food += 5;
        }
    }
}
