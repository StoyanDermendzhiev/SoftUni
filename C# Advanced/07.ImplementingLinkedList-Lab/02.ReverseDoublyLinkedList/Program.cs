using System;

namespace ReverseDoublyLinkedList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();

            for (int i = 0; i < 10; i++)
            {
                list.AddLast(i + 1);
            }

            list.ForEach(n => Console.WriteLine(n));

            list.Reverse();

            list.ForEach(n => Console.WriteLine(n));
        }
    }
}
