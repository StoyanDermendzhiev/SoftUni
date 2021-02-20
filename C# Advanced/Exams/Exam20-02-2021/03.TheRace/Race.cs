using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        private List<Racer> data;

        public Race(string name, int capacity)
        {
            data = new List<Racer>(capacity);
            Name = name;
            Capacity = capacity;
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count => data.Count;

        public void Add(Racer racer)
        {
            if (data.Count < Capacity)
            {
                data.Add(racer);
            }
        }

        public bool Remove(string name)
        {
            Racer racerToRemove = data.Find(r => r.Name == name);

            if (racerToRemove != null)
            {
                data.Remove(racerToRemove);
                return true;
            }

            return false;
        }

        public Racer GetOldestRacer()
        {
            Racer oldestRacer = data.OrderByDescending(r => r.Age).FirstOrDefault();

            return oldestRacer;
        }

        public Racer GetRacer(string name)
        {
            return data.Find(r => r.Name == name);
        }

        public Racer GetFastestRacer()
        {
            Racer fastestRacer = data.OrderByDescending(r => r.Car.Speed).FirstOrDefault();

            return fastestRacer;
        }

        public string Report()
        {
            return $"Racers participating at {Name}:{Environment.NewLine}" +
                   $"{string.Join(Environment.NewLine, data)}";
        }
    }
}
