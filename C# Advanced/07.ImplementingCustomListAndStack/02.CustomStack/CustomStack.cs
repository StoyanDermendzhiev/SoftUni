using System;
using System.Collections.Generic;
using System.Text;

namespace _02.CustomStack
{
    class CustomStack
    {
        private const int InitialCapacity = 4;

        private int[] items;

        private int count;

        public CustomStack()
        {
            count = 0;
            items = new int[InitialCapacity];
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public void Push(int element)
        {
            if (items.Length == count)
            {
                var nextItems = new int[items.Length * 2];

                for (int i = 0; i < items.Length; i++)
                {
                    nextItems[i] = items[i];
                }

                items = nextItems;
            }

            items[count] = element;
            count++;
        }

        public int Pop()
        {
            if (items.Length == 0)
            {
                throw new InvalidOperationException("CustomStack is empty");
            }

            var lastIndex = count - 1;
            int last = items[lastIndex];
            count--;

            if (count == items.Length / 2)
            {
                var previousItems = new int[count];

                for (int i = 0; i < count; i++)
                {
                    previousItems[i] = items[i];
                }

                items = previousItems;
            }

            return last;
        }

        public int Peek()
        {
            if (items.Length == 0)
            {
                throw new InvalidOperationException("CustomStack is empty");
            }

            int peekElement = items[count - 1];

            return peekElement;
        }

        public void ForEach(Action<object> action)
        {
            for (int i = 0; i < count; i++)
            {
                action(items[i]);
            }
        }
    }
}
