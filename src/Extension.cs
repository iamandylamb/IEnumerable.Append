using System;
using System.Collections.Generic;
using System.Linq;

namespace IEnumerable.Append
{
    public static class Extension
    {
        public static IEnumerable<T> Append<T>(this IEnumerable<T> collection, T item)
        {
            if (collection == null)
            {
                throw new ArgumentNullException("Collection should not be null");
            }

            return collection.Concat(Enumerable.Repeat(item, 1));
        }
    }
}
