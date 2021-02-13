using System;
using System.Linq;

namespace _03.Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Skip(1)
                .ToArray();

            MyStack<string> myStack = new MyStack<string>(firstInput);

            string commandData = Console.ReadLine();

            while (commandData != "END")
            {
                string[] command = commandData.Split();

                if (command[0] == "Push")
                {
                    myStack.Push(command[1]);
                }
                else if (command[0] == "Pop")
                {
                    myStack.Pop();
                }

                commandData = Console.ReadLine();
            }

            for (int i = 0; i < 2; i++)
            {
                foreach (var item in myStack)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
