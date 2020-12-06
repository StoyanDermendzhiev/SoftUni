using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDragons = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, Dragon>> dragonArmy = new Dictionary<string, Dictionary<string, Dragon>>();

            for (int i = 0; i < numberOfDragons; i++)
            {
                var dragonData = Console.ReadLine().Split();

                string type = dragonData[0];
                string name = dragonData[1];
                int damage = 0;
                int health = 0;
                int armor = 0;

                if (dragonData[2] == "null")
                {
                    damage = 45;
                }
                else
                {
                    damage = int.Parse(dragonData[2]);
                }

                if (dragonData[3] == "null")
                {
                    health = 250;
                }
                else
                {
                    health = int.Parse(dragonData[3]);
                }

                if (dragonData[4] == "null")
                {
                    armor = 10;
                }
                else
                {
                    armor = int.Parse(dragonData[4]);
                }

                Dragon dragon = new Dragon(damage, health, armor);

                if (dragonArmy.ContainsKey(type))
                {
                    if (dragonArmy[type].ContainsKey(name))
                    {
                        dragonArmy[type][name] = dragon;
                    }
                    else
                    {
                        dragonArmy[type].Add(name, dragon);
                    }
                }
                else
                {
                    dragonArmy.Add(type, new Dictionary<string, Dragon>());
                    dragonArmy[type].Add(name, dragon);
                }
            }

            foreach (var currentType in dragonArmy)
            {
                double sumDamage = 0;
                double sumHealht = 0;
                double sumArmor = 0;
                int count = 0;

                foreach (var currentName in currentType.Value)
                {
                    count++;
                    sumDamage += currentName.Value.Damage;
                    sumHealht += currentName.Value.Health;
                    sumArmor += currentName.Value.Armor;
                }

                Console.WriteLine($"{currentType.Key}::({sumDamage / count:f2}/{sumHealht / count:f2}/{sumArmor / count:f2})");

                foreach (var currentName in currentType.Value.OrderBy(x=>x.Key))
                {
                    Console.WriteLine($"-{currentName.Key} -> damage: {currentName.Value.Damage}, health: {currentName.Value.Health}, armor: {currentName.Value.Armor}");
                }
            }
        }
    }

    class Dragon
    {
        public Dragon(int damage, int health, int armor)
        {
            Damage = damage;
            Health = health;
            Armor = armor;
        }

        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
    }
}
