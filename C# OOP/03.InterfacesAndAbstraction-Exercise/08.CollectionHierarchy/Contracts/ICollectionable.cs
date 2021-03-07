using System.Collections.Generic;

namespace _08.CollectionHierarchy.Contracts
{
    public interface ICollectionable
    {
        List<string> Collection { get; }

        int Count { get; }
    }
}
