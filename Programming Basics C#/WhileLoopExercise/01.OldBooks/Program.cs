using System;

namespace _01.OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string favBookTitle = Console.ReadLine();
            string bookTitle = Console.ReadLine();
            int countBooks = 0;
            while (bookTitle != "No More Books")
            {
                if (bookTitle == favBookTitle)
                {
                    Console.WriteLine($"You checked {countBooks} books and found it.");
                    Environment.Exit(0);
                }
                countBooks++;
                bookTitle = Console.ReadLine();
            }
            Console.WriteLine($"The book you search is not here!");
            Console.WriteLine($"You checked {countBooks} books.");
        }
    }
}
