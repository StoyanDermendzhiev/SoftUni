using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int pets = int.Parse(Console.ReadLine());
            double money = dogs * 2.5 + pets * 4;
            Console.WriteLine($"{money} lv.");
        }
    }
}
