using System.Collections.Generic;
using _08.CollectionHierarchy.Contracts;

namespace _08.CollectionHierarchy.Models
{
    public class AddCollection : IAddable
    {
        private int capacity = 100;

        public AddCollection()
        {
            Collection = new List<string>(capacity);
        }

        public List<string> Collection { get; private set; }

        public int Count => Collection.Count;
        
        public int Add(string item)
        {
            Collection.Add(item);

            return Count - 1;
        }

    }
}
