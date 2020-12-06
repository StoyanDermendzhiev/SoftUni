using System;

namespace _10.RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            var headsetPrice = double.Parse(Console.ReadLine());
            var mousePrice = double.Parse(Console.ReadLine());
            var keyboardPrice = double.Parse(Console.ReadLine());
            var displayPrice = double.Parse(Console.ReadLine());

            var expences = headsetPrice * (lostGames / 2);
            expences += mousePrice * (lostGames / 3);
            expences += keyboardPrice * (lostGames / 6);
            expences += displayPrice * (lostGames / 12);

            Console.WriteLine($"Rage expenses: {expences:f2} lv.");
        }
    }
}
