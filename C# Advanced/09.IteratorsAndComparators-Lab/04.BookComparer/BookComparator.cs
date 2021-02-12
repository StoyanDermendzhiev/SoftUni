using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class BookComparator : IComparer<Book>
    {
        public int Compare(Book one, Book two)
        {
            int result = one.Title.CompareTo(two.Title);

            if (result == 0)
            {
                result = two.Year.CompareTo(one.Year);
            }

            return result;
        }
    }
}
