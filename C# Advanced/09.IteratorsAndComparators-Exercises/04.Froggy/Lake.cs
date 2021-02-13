using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _04.Froggy
{
    public class Lake : IEnumerable<int>
    {
        private List<int> stones;

        public Lake(List<int> stones)
        {
            this.stones = stones;
        }

        public IEnumerator<int> GetEnumerator()
        {
            Stack stack = new Stack();
            Queue queue = new Queue();
            
            for (int i = 0; i < stones.Count; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    stack.Push(stones[i]);
                }
                else
                {
                    queue.Enqueue(stones[i]);
                }
            }

            foreach (int item in queue)
            {
                yield return item;
            }

            foreach (int item in stack)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
