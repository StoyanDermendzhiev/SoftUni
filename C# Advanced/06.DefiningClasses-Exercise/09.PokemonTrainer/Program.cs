using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

            while (input != "Tournament")
            {
                string[] pokemonInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string trainerName = pokemonInfo[0];
                string pokemonName = pokemonInfo[1];
                string pokemonElement = pokemonInfo[2];
                int pokemonHealth = int.Parse(pokemonInfo[3]);

                Pokemon currPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (trainers.ContainsKey(trainerName))
                {
                    trainers[trainerName].Pokemons.Add(currPokemon);
                }
                else
                {
                    Trainer currTrainer = new Trainer(trainerName, new List<Pokemon>());
                    currTrainer.Pokemons.Add(currPokemon);
                    trainers.Add(trainerName, currTrainer);
                }

                input = Console.ReadLine();
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                foreach (Trainer trainer in trainers.Values)
                {
                    if (trainer.Pokemons.Exists(p => p.Element == command))
                    {
                        trainer.NumberOfBadges++;
                    }
                    else
                    {
                        trainer.Pokemons.ForEach(p => p.Health -= 10);
                        trainer.Pokemons = trainer.Pokemons.Where(p => p.Health > 0).ToList();
                    }
                }

                command = Console.ReadLine();
            }

            foreach (Trainer trainer in trainers.Values.OrderByDescending(t => t.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
            }
        }
    }
}
