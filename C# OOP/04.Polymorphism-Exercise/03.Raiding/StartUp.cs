using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<BaseHero> heroes = new List<BaseHero>();

            while (heroes.Count < n)
            {
                string heroName = Console.ReadLine();
                string heroType = Console.ReadLine();

                if (heroType == nameof(Paladin))
                {
                    heroes.Add(new Paladin(heroName));
                }
                else if (heroType == nameof(Druid))
                {
                    heroes.Add(new Druid(heroName));
                }
                else if (heroType == nameof(Rogue))
                {
                    heroes.Add(new Rogue(heroName));
                }
                else if (heroType == nameof(Warrior))
                {
                    heroes.Add(new Warrior(heroName));
                }
                else
                {
                    Console.WriteLine("Invalid hero!");
                }
            }

            int bossPower = int.Parse(Console.ReadLine());

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.CastAbility());
            }

            if (heroes.Sum(h => h.Power) >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
