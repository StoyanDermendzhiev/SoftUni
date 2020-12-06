using System;

namespace _09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            var amountOfMoney = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            var lightsabersPrice = double.Parse(Console.ReadLine());
            var robesPrice = double.Parse(Console.ReadLine());
            var beltsPrice = double.Parse(Console.ReadLine());

            var lightsabersNumber = Math.Ceiling(students * 1.1);
            int beltsNumber = students - students / 6;

            var totalMoney = lightsabersNumber * lightsabersPrice + robesPrice * students + beltsPrice * beltsNumber;
            if (totalMoney <= amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalMoney:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalMoney-amountOfMoney:f2}lv more.");
            }
        }
    }
}
