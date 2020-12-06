using System;

namespace _01.ShopingForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            double pencilPrice = 4.75;
            double felttipPensPrice = 1.80;
            double sketchbookPrice = 6.50;
            double notebookPrice = 2.50;

            int pencilNumber = int.Parse(Console.ReadLine());
            int felttipPensNumber = int.Parse(Console.ReadLine());
            int sketchbookNumber = int.Parse(Console.ReadLine());
            int notebookNumber = int.Parse(Console.ReadLine());

            double totalMoney = pencilPrice * pencilNumber + felttipPensPrice * felttipPensNumber + sketchbookNumber * sketchbookPrice + notebookPrice * notebookNumber;
            double finalTotal = totalMoney - totalMoney * 0.05;

            Console.WriteLine($"Your total is {finalTotal:f2}lv");
        }
    }
}
