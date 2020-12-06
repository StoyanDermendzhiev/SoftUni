using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HeroesOfCodeAndLogicVII
{
    class Hero
    {
        public Hero(int hitPoints, int manaPoints)
        {
            HP = hitPoints;
            MP = manaPoints;
        }

        public int HP { get; set; }
        public int MP { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfHeroes = int.Parse(Console.ReadLine());

            Dictionary<string, Hero> heroes = new Dictionary<string, Hero>();

            for (int i = 0; i < numberOfHeroes; i++)
            {
                string[] currentHero = Console.ReadLine().Split();
                string heroName = currentHero[0];
                int hitPoints = int.Parse(currentHero[1]);
                int manaPoints = int.Parse(currentHero[2]);

                Hero hero = new Hero(hitPoints, manaPoints);

                heroes.Add(heroName, hero);
            }

            string inputCommand = Console.ReadLine();

            while (inputCommand != "End")
            {
                string[] command = inputCommand.Split(" - ");
                string currentCommand = command[0];
                string heroName = command[1];

                if (currentCommand == "CastSpell")
                {
                    int neededMP = int.Parse(command[2]);
                    string spellName = command[3];

                    if (neededMP <= heroes[heroName].MP)
                    {
                        heroes[heroName].MP -= neededMP;

                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[heroName].MP} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (currentCommand == "TakeDamage")
                {
                    int damage = int.Parse(command[2]);
                    string attacker = command[3];

                    if (damage >= heroes[heroName].HP)
                    {
                        heroes.Remove(heroName);

                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                    }
                    else
                    {
                        heroes[heroName].HP -= damage;

                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName].HP} HP left!");
                    }
                }
                else if (currentCommand == "Recharge")
                {
                    int amount = int.Parse(command[2]);

                    if (heroes[heroName].MP + amount > 200)
                    {
                        int amountRecovered = 200 - heroes[heroName].MP;
                        heroes[heroName].MP = 200;

                        Console.WriteLine($"{heroName} recharged for {amountRecovered} MP!");
                    }
                    else
                    {
                        heroes[heroName].MP += amount;

                        Console.WriteLine($"{heroName} recharged for {amount} MP!");
                    }
                }
                else if (currentCommand == "Heal")
                {
                    int amount = int.Parse(command[2]);

                    if (heroes[heroName].HP + amount > 100)
                    {
                        int amountRecovered = 100 - heroes[heroName].HP;
                        heroes[heroName].HP = 100;

                        Console.WriteLine($"{heroName} healed for {amountRecovered} HP!");
                    }
                    else
                    {
                        heroes[heroName].HP += amount;

                        Console.WriteLine($"{heroName} healed for {amount} HP!");
                    }
                }

                inputCommand = Console.ReadLine();
            }

            foreach (var hero in heroes.OrderByDescending(x=>x.Value.HP)
                                       .ThenBy(x=>x.Key))
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"  HP: {hero.Value.HP}");
                Console.WriteLine($"  MP: {hero.Value.MP}");
            }
        }
    }
}
