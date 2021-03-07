using System.Collections.Generic;
using _08.CollectionHierarchy.Contracts;

namespace _08.CollectionHierarchy.Models
{
    public class AddRemoveCollection : IAddRemovable
    {
        private int capacity = 100;

        public AddRemoveCollection()
        {
            Collection = new List<string>(capacity);
        }

        public List<string> Collection { get; }

        public int Count => Collection.Count;

        public int Add(string item)
        {
            Collection.Insert(0, item);

            return 0;
        }

        public string Remove()
        {
            string removedItem = Collection[Count - 1];

            Collection.Remove(removedItem);

            return removedItem;
        }
    }
}
