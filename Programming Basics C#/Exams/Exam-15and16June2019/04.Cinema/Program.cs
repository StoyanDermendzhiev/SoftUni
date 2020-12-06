using System;

namespace _04.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            int seats = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int totalMoney = 0;
            while (input != "Movie time!")
            {
                int peopleIn = int.Parse(input);
                int moneyPerGroup = 0;
                if (seats < peopleIn)
                {
                    Console.WriteLine("The cinema is full.");
                    Console.WriteLine($"Cinema income - {totalMoney} lv.");
                    return;
                }
                moneyPerGroup = peopleIn * 5;
                if (peopleIn % 3 == 0)
                {
                    moneyPerGroup -= 5;
                }
                
                seats -= peopleIn;
                totalMoney += moneyPerGroup;
                input = Console.ReadLine();
            }
            Console.WriteLine($"There are {seats} seats left in the cinema.");
            Console.WriteLine($"Cinema income - {totalMoney} lv.");
        }
    }
}
