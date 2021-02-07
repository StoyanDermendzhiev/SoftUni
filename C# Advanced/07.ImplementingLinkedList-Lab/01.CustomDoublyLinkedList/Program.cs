using System;

namespace CustomDoublyLinkedList
{
    class StartUp
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();

            for (int i = 0; i < 10; i++)
            {
                list.AddLast(i);
            }

            Console.WriteLine(list.RemoveFirst());
            Console.WriteLine(list.RemoveLast());
            Console.WriteLine();
            list.ForEach(n => Console.WriteLine(n));

            int[] listToArray = list.ToArray();

            list.AddFirst(100);
            list.AddLast(100);

            list.ForEach(n => Console.WriteLine(n));
        }
    }
}
