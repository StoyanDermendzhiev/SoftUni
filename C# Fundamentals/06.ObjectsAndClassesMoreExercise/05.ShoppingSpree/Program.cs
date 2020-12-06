using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] personInput = Console.ReadLine()
                                          .Split(";", StringSplitOptions.RemoveEmptyEntries);
            string[] productInput = Console.ReadLine()
                                          .Split(";", StringSplitOptions.RemoveEmptyEntries);

            List<Product> products = new List<Product>();
            List<Person> people = new List<Person>();

            for (int i = 0; i < personInput.Length; i++)
            {
                string[] person = personInput[i].Split("=");
                string name = person[0];
                double money = double.Parse(person[1]);

                Person currentPerson = new Person(name, money);

                people.Add(currentPerson);
            }

            for (int i = 0; i < productInput.Length; i++)
            {
                string[] product = productInput[i].Split("=");
                string name = product[0];
                double price = double.Parse(product[1]);

                Product currentProduct = new Product(name, price);

                products.Add(currentProduct);
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] currentCommand = command.Split();
                string personName = currentCommand[0];
                string productName = currentCommand[1];

                bool isPersonExist = people.Exists(x => x.Name == personName);
                bool isProductExist = products.Exists(x => x.Name == productName);

                if (isPersonExist && isProductExist)
                {
                    Person currentPerson = people.Find(x => x.Name == personName);
                    Product currentProduct = products.Find(x => x.Name == productName);

                    if (currentProduct.Price <= currentPerson.Money)
                    {
                        currentPerson.Money -= currentProduct.Price;
                        currentPerson.BagOfProducts.Add(currentProduct);
                        Console.WriteLine($"{currentPerson.Name} bought {currentProduct.Name}");
                    }
                    else
                    {
                        Console.WriteLine($"{currentPerson.Name} can't afford {currentProduct.Name}");
                    }
                }

                command = Console.ReadLine();
            }

            foreach (Person currentPerson in people)
            {
                if (currentPerson.BagOfProducts.Count > 0)
                {
                    Console.WriteLine($"{currentPerson.Name} - {currentPerson}");
                }
                else
                {
                    Console.WriteLine($"{currentPerson.Name} - Nothing bought");
                }
            }
        }
    }

    class Person
    {
        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            BagOfProducts = new List<Product>();
        }

        public string Name { get; set; }
        public double Money { get; set; }
        public List<Product> BagOfProducts { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < BagOfProducts.Count - 1; i++)
            {
                sb.Append($"{BagOfProducts[i].Name}, ");
            }

            sb.Append(BagOfProducts[BagOfProducts.Count - 1].Name);

            return sb.ToString();
        }
    }

    class Product
    {
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }
    }

}
