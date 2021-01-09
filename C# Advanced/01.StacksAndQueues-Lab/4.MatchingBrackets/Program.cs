using System;
using System.Collections.Generic;

namespace _04.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();

            var stack = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    stack.Push(i);
                }
                else if (expression[i] == ')')
                {
                    int startIndex = stack.Pop();
                    int length = i - startIndex + 1;

                    Console.WriteLine(expression.Substring(startIndex, length));
                }
            }
        }
    }
}
