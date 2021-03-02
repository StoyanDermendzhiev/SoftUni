using System;
using System.Collections.Generic;

namespace _03.ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                string[] personInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
                List<Person> people = new List<Person>();

                foreach (var item in personInput)
                {
                    string[] personData = item.Split('=', StringSplitOptions.RemoveEmptyEntries);
                    Person person = new Person(personData[0], decimal.Parse(personData[1]));
                    people.Add(person);
                }

                string[] productInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
                List<Product> products = new List<Product>();

                foreach (var item in productInput)
                {
                    string[] productData = item.Split('=', StringSplitOptions.RemoveEmptyEntries);
                    Product product = new Product(productData[0], decimal.Parse(productData[1]));
                    products.Add(product);
                }

                string command = Console.ReadLine();

                while (command != "END")
                {
                    string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    string currentPersonName = cmdArgs[0];
                    string currentProductName = cmdArgs[1];

                    Person person = people.Find(p => p.Name == currentPersonName);

                    Product product = products.Find(p => p.Name == currentProductName);

                    if (person.Money >= product.Cost)
                    {
                        int index = people.IndexOf(person);
                        people.Remove(person);
                        person.Money -= product.Cost;
                        person.BagOfProducts.Add(currentProductName);
                        people.Insert(index, person);

                        Console.WriteLine($"{person.Name} bought {currentProductName}");
                    }
                    else
                    {
                        Console.WriteLine($"{person.Name} can't afford {currentProductName}");
                    }

                    command = Console.ReadLine();
                }

                foreach (Person person in people)
                {
                    if (person.BagOfProducts.Count != 0)
                    {
                        Console.WriteLine($"{person.Name} - {string.Join(", ", person.BagOfProducts)}");
                    }
                    else
                    {
                        Console.WriteLine($"{person.Name} - Nothing bought");
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }
    }
}
