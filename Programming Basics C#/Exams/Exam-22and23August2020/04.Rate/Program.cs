using System;

namespace _04.Rate
{
    class Program
    {
        static void Main(string[] args)
        {
            double simpleInterest = 3.00 / 100;
            double complexInterest = 2.7 / 100;

            double nestedSum = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());

            string interestType = "";
            double diffInterest = 0;
            double totalSumComplexInterest = nestedSum;

            double totalSumSimpleInterest = nestedSum * simpleInterest * months + nestedSum;
            for (int i = 1; i <= months; i++)
            {
                totalSumComplexInterest += totalSumComplexInterest * complexInterest;
            }

            if (totalSumSimpleInterest > totalSumComplexInterest)
            {
                interestType = "simple";
                diffInterest = totalSumSimpleInterest - totalSumComplexInterest; ;
            }
            else if (totalSumSimpleInterest < totalSumComplexInterest)
            {
                interestType = "complex";
                diffInterest = totalSumComplexInterest - totalSumSimpleInterest;
            }

            Console.WriteLine($"Simple interest rate: {totalSumSimpleInterest:f2} lv.");
            Console.WriteLine($"Complex interest rate: {totalSumComplexInterest:f2} lv.");
            Console.WriteLine($"Choose a {interestType} interest rate. You will win {diffInterest:f2} lv.");
        }
    }
}
