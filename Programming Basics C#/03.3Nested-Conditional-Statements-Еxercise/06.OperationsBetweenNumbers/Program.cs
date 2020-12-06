using System;

namespace _06.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char simpleOperator = char.Parse(Console.ReadLine());
            //Calculations
            double result = 0;
            bool evenOrOdd = true;
            switch (simpleOperator)
            {
                case '+':
                    result = n1 + n2;
                    evenOrOdd = (result % 2 == 0);
                    break;
                case '-':
                    result = n1 - n2;
                    evenOrOdd = (result % 2 == 0);
                    break;
                case '*':
                    result = n1 * n2;
                    evenOrOdd = (result % 2 == 0);
                    break;
                case '/':
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        double n2Double = Convert.ToDouble(n2);
                        result = n1 / n2Double;
                        Console.WriteLine($"{n1} / {n2} = {result:f2}");
                    }
                    break;
                case '%':
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        result = n1 % n2;
                        Console.WriteLine($"{n1} % {n2} = {result}");
                    }
                    break;
            }
            if (simpleOperator == '+' || simpleOperator == '-' || simpleOperator == '*')
            {
                if (evenOrOdd == true)
                {
                    Console.WriteLine($"{n1} {simpleOperator} {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} {simpleOperator} {n2} = {result} - odd");

                }
            }
        }
    }
}
