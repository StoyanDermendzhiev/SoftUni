using System;
using System.Collections.Generic;
using System.Text;

namespace _02.CustomStack
{
    class CustomStack<T>
    {
        private const int InitialCapacity = 4;

        private T[] items;

        private int count;

        public CustomStack()
        {
            count = 0;
            items = new T[InitialCapacity];
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public void Push(T element)
        {
            if (items.Length == count)
            {
                var nextItems = new T[items.Length * 2];

                for (int i = 0; i < items.Length; i++)
                {
                    nextItems[i] = items[i];
                }

                items = nextItems;
            }

            items[count] = element;
            count++;
        }

        public T Pop()
        {
            if (items.Length == 0)
            {
                throw new InvalidOperationException("CustomStack is empty");
            }

            var lastIndex = count - 1;
            T last = items[lastIndex];
            count--;

            if (count == items.Length / 2)
            {
                var previousItems = new T[count];

                for (int i = 0; i < count; i++)
                {
                    previousItems[i] = items[i];
                }

                items = previousItems;
            }

            return last;
        }

        public T Peek()
        {
            if (items.Length == 0)
            {
                throw new InvalidOperationException("CustomStack is empty");
            }

            T peekElement = items[count - 1];

            return peekElement;
        }

        public void ForEach(Action<T> action)
        {
            for (int i = 0; i < count; i++)
            {
                action(items[i]);
            }
        }
    }
}
