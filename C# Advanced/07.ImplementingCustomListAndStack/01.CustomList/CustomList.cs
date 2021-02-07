using System;
using System.Collections.Generic;
using System.Text;

namespace _01.CustomList
{
    class CustomList<T>
    {
        private const int InitialCapacity = 2;

        private T[] items;

        public CustomList()
        {
            this.items = new T[InitialCapacity];
        }

        public int Count { get; private set; }

        public T this[int index]
        {
            get
            {
                if (index >= Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return items[index];
            }
            set
            {
                if (index >= Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                items[index] = value;
            }
        }

        public void Add(T item)
        {
            if (Count == items.Length)
            {
                Resize();
            }

            items[Count] = item;
            Count++;
        }

        public T RemoveAt(int index)
        {
            if (index >= Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            T item = items[index];
            items[index] = default(T);
            Shift(index);

            Count--;

            if (Count <= items.Length / 2)
            {
                Shrink();
            }

            return item;
        }

        public void Insert(int index, T element)
        {
            if (index > Count)
            {
                throw new IndexOutOfRangeException();
            }

            if (Count == items.Length)
            {
                Resize();
            }

            ShiftToRight(index);

            items[index] = element;
            Count++;
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < Count; i++)
            {
                if (items[i].Equals(element))
                {
                    return true;
                }
            }

            return false;
        }

        public void Swap (int firstIndex, int secondIndex)
        {
            if (firstIndex < 0 || firstIndex >= Count || secondIndex < 0 || secondIndex >= Count)
            {
                throw new IndexOutOfRangeException();
            }

            T currentElement = items[firstIndex];
            items[firstIndex] = items[secondIndex];
            items[secondIndex] = currentElement;
        }

        private void Resize()
        {
            T[] copy = new T[items.Length * 2];

            for (int i = 0; i < items.Length; i++)
            {
                copy[i] = items[i];
            }

            items = copy;
        }

        private void Shift(int index)
        {
            for (int i = index; i < Count - 1; i++)
            {
                items[i] = items[i + 1];
            }
        }

        private void Shrink()
        {
            T[] copy = new T[items.Length / 2];

            for (int i = 0; i < Count; i++)
            {
                copy[i] = items[i];
            }

            items = copy;
        }

        private void ShiftToRight(int index)
        {
            for (int i = Count; i > index; i--)
            {
                items[i] = items[i - 1];
            }
        }
    }
}
