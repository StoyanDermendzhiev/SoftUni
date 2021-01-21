using System;
using System.Collections.Generic;

namespace _03.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();

            while (input != "Revision")
            {
                string[] productData = input.Split(", ");
                string shop = productData[0];
                string product = productData[1];
                double price = double.Parse(productData[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());
                }

                shops[shop].Add(product, price);

                input = Console.ReadLine();
            }

            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
