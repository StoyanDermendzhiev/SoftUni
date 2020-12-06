using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] data = input.Split();

                string serialNumber = data[0];
                string itemName = data[1];
                int itemQuantity = int.Parse(data[2]);
                double itemPrice = double.Parse(data[3]);

                Box currentBox = new Box()
                {
                    SerialNumber = serialNumber,
                    ItemQuantity = itemQuantity,
                    PriceForBox = itemQuantity * itemPrice,
                };

                currentBox.Item = new Item()
                {
                    Name = itemName,
                    Price = itemPrice,
                };

                boxes.Add(currentBox);

                input = Console.ReadLine();
            }

            List<Box> sortedBoxes = boxes.OrderBy(x => x.PriceForBox).ToList();
            sortedBoxes.Reverse();

            foreach (Box currentBox in sortedBoxes)
            {
                Console.WriteLine(currentBox.SerialNumber);
                Console.WriteLine($"-- {currentBox.Item.Name} - ${currentBox.Item.Price:f2}: {currentBox.ItemQuantity}");
                Console.WriteLine($"-- ${currentBox.PriceForBox:f2}");
            }
        }
        class Item
        {
            public string Name { get; set; }
            public double Price { get; set; }
        }
        class Box
        {
            public string SerialNumber { get; set; }
            public Item Item { get; set; }
            public int ItemQuantity { get; set; }
            public double PriceForBox { get; set; }
        }
    }
}
