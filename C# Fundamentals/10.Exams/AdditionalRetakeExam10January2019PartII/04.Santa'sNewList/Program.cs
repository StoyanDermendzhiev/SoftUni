using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Santa_sNewList
{

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> children = new Dictionary<string, int>();
            Dictionary<string, int> toys = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] childInfo = input.Split("->");

                if (childInfo[0] != "Remove")
                {
                    string childName = childInfo[0];
                    string toyType = childInfo[1];
                    int amount = int.Parse(childInfo[2]);

                    if (children.ContainsKey(childName))
                    {
                        children[childName] += amount;
                    }
                    else
                    {
                        children.Add(childName, amount);
                    }

                    if (toys.ContainsKey(toyType))
                    {
                        toys[toyType] += amount;
                    }
                    else
                    {
                        toys.Add(toyType, amount);
                    }
                }
                else
                {
                    string childName = childInfo[1];
                    children.Remove(childName);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Children:");

            foreach (var child in children.OrderByDescending(x=>x.Value)
                                          .ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{child.Key} -> {child.Value}");
            }

            Console.WriteLine("Presents:");

            foreach (var toy in toys)
            {
                Console.WriteLine($"{toy.Key} -> {toy.Value}");
            }
        }
    }
}
