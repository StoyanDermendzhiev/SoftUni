using System;
using System.Collections.Generic;

namespace _09.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string text = string.Empty;
            var stack = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                int command = int.Parse(input[0]);

                switch (command)
                {
                    case 1:
                        string someString = input[1];
                        text += someString;
                        stack.Push(text);
                        break;
                    case 2:
                        int count = int.Parse(input[1]);

                        if (count > text.Length)
                        {
                            text = string.Empty;
                        }
                        else
                        {
                            text = text.Remove(text.Length - count);
                        }

                        stack.Push(text);
                        break;
                    case 3:
                        int index = int.Parse(input[1]);
                        Console.WriteLine(text[index - 1]);
                        break;
                    case 4:
                        stack.Pop();
                        text = stack.Pop();
                        stack.Push(text);
                        break;
                }
            }
        }
    }
}
