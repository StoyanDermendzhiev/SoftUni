using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Collection
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> items;
        private int index;

        public ListyIterator(params T[] items)
        {
            this.items = items.ToList();
            index = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in items)
            {
                yield return item;
            }
        }

        public bool HasNext() => index < items.Count - 1;

        public bool Move()
        {
            if (HasNext())
            {
                index++;
                return true;
            }

            return false;
        }

        public void Print()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(items[index]);
            }
        }

        public void PrintAll()
        {
            if (items.Count != 0)
            {
                Console.WriteLine(string.Join(" ", items));
            }
            else
            {
                Console.WriteLine("Invalid Operation!");
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
