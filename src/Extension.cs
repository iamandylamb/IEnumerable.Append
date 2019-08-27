using System.Collections.Generic;
using System.Linq;

namespace IEnumerable.Append
{
    public static class Extension
    {
        public static IEnumerable<T> Append<T>(this IEnumerable<T> collection, T item)
        {
            return collection.Concat(Enumerable.Repeat(item, 1));
        }
    }
}
