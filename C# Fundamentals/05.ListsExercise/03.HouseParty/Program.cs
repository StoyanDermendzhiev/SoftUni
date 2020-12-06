using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> partyPersons = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (command[2])
                {
                    case "going!":
                        if (partyPersons.Contains(command[0]))
                        {
                            Console.WriteLine($"{command[0]} is already in the list!");
                        }
                        else
                        {
                            partyPersons.Add(command[0]);
                        }
                        break;
                    case "not":
                        if (partyPersons.Contains(command[0]))
                        {
                            partyPersons.Remove(command[0]);
                        }
                        else
                        {
                            Console.WriteLine($"{command[0]} is not in the list!");
                        }
                        break;
                }
            }

            for (int i = 0; i < partyPersons.Count; i++)
            {
                Console.WriteLine(partyPersons[i]);
            }
        }
    }
}
