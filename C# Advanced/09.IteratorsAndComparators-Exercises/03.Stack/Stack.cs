using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Stack
{
    public class MyStack<T> : IEnumerable<T>
    {
        private List<T> items;

        public MyStack(params T[] items)
        {
            this.items = items.ToList();
        }

        public void Push(T item)
        {
            items.Add(item);
        }

        public void Pop()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("No elements");
                return;
            }

            items.RemoveAt(items.Count - 1);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = items.Count - 1; i >= 0; i--)
            {
                yield return items[i];
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
