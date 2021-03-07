using System;
using System.Collections.Generic;
using System.Linq;
using _04.BorderControl.Contracts;
using _04.BorderControl.Models;

namespace _04.BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IIdentifiable> idenfiables = new List<IIdentifiable>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] parts = line.Split();

                if (parts.Length == 3)
                {
                    string name = parts[0];
                    int age = int.Parse(parts[1]);
                    string id = parts[2];

                    idenfiables.Add(new Citizen(name, age, id));
                }
                else
                {
                    string model = parts[0];
                    string id = parts[1];

                    idenfiables.Add(new Robot(id, model));
                }
            }

            string filterId = Console.ReadLine();

            var filtered = idenfiables.Where(i => i.Id.EndsWith(filterId)).ToList();

            foreach (var identifiable in filtered)
            {
                Console.WriteLine(identifiable.Id);
            }
        }
    }
}
