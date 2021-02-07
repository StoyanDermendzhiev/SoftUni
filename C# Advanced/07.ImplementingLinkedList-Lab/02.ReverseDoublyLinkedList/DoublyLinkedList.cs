using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseDoublyLinkedList
{
    public class DoublyLinkedList
    {
        private class Node
        {
            public Node(int value)
            {
                Value = value;
            }

            public int Value { get; set; }

            public Node NextNode { get; set; }

            public Node PreviousNode { get; set; }
        }

        private Node head;

        private Node tail;

        private bool isReversed = false;

        public int Count { get; set; }

        public void Reverse()
        {
            Node temp = head;
            head = tail;
            tail = temp;
            isReversed = !isReversed;
        }

        public void AddFirst(int element)
        {
            if (Count == 0)
            {
                head = tail = new Node(element);
            }
            else
            {
                var newHead = new Node(element);
                newHead.NextNode = head;
                head.PreviousNode = newHead;
                head = newHead;
            }

            Count++;
        }

        public void AddLast(int element)
        {
            if (Count == 0)
            {
                head = tail = new Node(element);
            }
            else
            {
                var newTail = new Node(element);
                newTail.PreviousNode = tail;
                tail.NextNode = newTail;
                tail = newTail;
            }

            Count++;
        }

        public void ForEach(Action<int> action)
        {
            var currNode = head;

            while (currNode != null)
            {
                action(currNode.Value);
                if (!isReversed)
                {
                    currNode = currNode.NextNode;
                }
                else
                {
                    currNode = currNode.PreviousNode;
                }
            }
        }
    }
}
