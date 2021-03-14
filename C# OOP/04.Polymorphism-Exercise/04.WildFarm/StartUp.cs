using System;
using System.Collections.Generic;
using _04.WildFarm.Animals;
using _04.WildFarm.Foods;

namespace _04.WildFarm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            while (true)
            {
                string inputLine = Console.ReadLine();

                if (inputLine == "End")
                {
                    break;
                }

                string[] animalInfo = inputLine.Split();

                Animal animal = CreateAnimal(animalInfo);
                animals.Add(animal);

                string[] foodInfo = Console.ReadLine().Split();

                Food food = CreateFood(foodInfo);

                Console.WriteLine(animal.ProduceSound());

                try
                {
                    animal.Eat(food);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        private static Animal CreateAnimal(string[] animalInfo)
        {
            string type = animalInfo[0];
            string name = animalInfo[1];
            double weight = double.Parse(animalInfo[2]);

            Animal animal = null;

            if (type == nameof(Hen))
            {
                double wingSize = double.Parse(animalInfo[3]);
                animal = new Hen(name, weight, wingSize);
            }
            else if (type == nameof(Owl))
            {
                double wingSize = double.Parse(animalInfo[3]);
                animal = new Owl(name, weight, wingSize);
            }
            else if (type == nameof(Mouse))
            {
                string livingRegion = animalInfo[3];
                animal = new Mouse(name, weight, livingRegion);
            }
            else if (type == nameof(Dog))
            {
                string livingRegion = animalInfo[3];
                animal = new Dog(name, weight, livingRegion);
            }
            else if (type == nameof(Cat))
            {
                string livingRegion = animalInfo[3];
                string breed = animalInfo[4];
                animal = new Cat(name, weight, livingRegion, breed);
            }
            else if (type == nameof(Tiger))
            {
                string livingRegion = animalInfo[3];
                string breed = animalInfo[4];
                animal = new Tiger(name, weight, livingRegion, breed);
            }

            return animal;
        }

        private static Food CreateFood(string[] foodInfo)
        {
            string type = foodInfo[0];
            int quantity = int.Parse(foodInfo[1]);

            Food food = null;

            if (type == nameof(Vegetable))
            {
                food = new Vegetable(quantity);
            }
            else if (type == nameof(Fruit))
            {
                food = new Fruit(quantity);
            }
            else if (type == nameof(Meat))
            {
                food = new Meat(quantity);
            }
            else if (type == nameof(Seeds))
            {
                food = new Seeds(quantity);
            }

            return food;
        }
    }
}
