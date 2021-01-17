using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] sequence = Console.ReadLine()
                                     .ToCharArray();

            var stack = new Stack<char>();

            bool isBalanced = true;

            for (int i = 0; i < sequence.Length; i++)
            {
                char currentChar = sequence[i];
                if (currentChar == '(' || currentChar == '{' || currentChar == '[')
                {
                    stack.Push(currentChar);
                }
                else if ((currentChar == ')' || currentChar == '}' || currentChar == ']') && stack.Count > 0)
                {
                    char previosChar = stack.Pop();

                    if (!((previosChar == '(' && currentChar == ')') ||
                       (previosChar == '{' && currentChar == '}') ||
                       (previosChar == '[' && currentChar == ']')))
                    {
                        isBalanced = false;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("NO");
                    return;
                }
            }

            if (isBalanced && stack.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
