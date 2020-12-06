using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<Dwarf, int> dwarfs = new Dictionary<Dwarf, int>();

            while (input != "Once upon a time")
            {
                string[] dwarfData = input.Split(" <:> ");
                string name = dwarfData[0];
                string hatColor = dwarfData[1];
                int physics = int.Parse(dwarfData[2]);

                Dwarf dwarf = new Dwarf(hatColor, name);

                if (dwarfs.ContainsKey(dwarf))
                {
                    if (dwarfs[dwarf] < physics)
                    {
                        dwarfs[dwarf] = physics;
                    }
                }
                else
                {
                    dwarfs.Add(dwarf, physics);
                }

                input = Console.ReadLine();
            }

            foreach (var current in dwarfs.OrderByDescending(x => x.Value)
                                          .ThenBy(x => x.Key.HatColor.Count()))
            {
                Console.WriteLine($"({current.Key.HatColor}) {current.Key.Name} <-> {current.Value}");
            }

        }
    }

    class Dwarf
    {
        public Dwarf(string hatColor, string name)
        {
            HatColor = hatColor;
            Name = name;
        }

        public string HatColor { get; set; }
        public string Name { get; set; }
    }
}
