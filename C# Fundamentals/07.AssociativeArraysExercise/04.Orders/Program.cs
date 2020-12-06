using System;
using System.Collections.Generic;

namespace _04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Product> products = new Dictionary<string, Product>();

            while (input != "buy")
            {
                string[] currentProductInfo = input.Split();

                string productName = currentProductInfo[0];
                double productPrice = double.Parse(currentProductInfo[1]);
                int productQuantity = int.Parse(currentProductInfo[2]);

                Product product = new Product(productPrice, productQuantity);

                if (products.ContainsKey(productName))
                {
                    products[productName].Price = productPrice;
                    products[productName].Quantity += productQuantity;
                }
                else
                {
                    products.Add(productName, product);
                }

                input = Console.ReadLine();
            }

            foreach (var currentProduct in products)
            {
                Console.WriteLine($"{currentProduct.Key} -> {currentProduct.Value.Price * currentProduct.Value.Quantity:f2}");
            }
        }
    }

    class Product
    {
        public Product(double price, int quantity)
        {
            Price = price;
            Quantity = quantity;
        }

        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
