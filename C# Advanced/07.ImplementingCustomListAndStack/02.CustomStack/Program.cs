using System;

namespace _02.CustomStack
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomStack<string> stack = new CustomStack<string>();

            stack.Push("10");
            stack.Push("20");
            stack.Push("30");
            stack.Push("40");
            stack.Push("50");
            stack.Peek();
            stack.Pop();
            stack.ForEach(s => Console.WriteLine(s));
        }
    }
}
