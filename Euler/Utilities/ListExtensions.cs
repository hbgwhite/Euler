using System.Collections.Generic;

namespace Euler.Utilities
{
    public static class ListExtensions
    {
        public static List<int> AddAndReturn(this List<int> list, int value)
        {
            list.Add(value);
            return list;
        }
        public static List<int> AddAndReturn(this List<int> list, IList<int> values)
        {
            list.AddRange(values);
            return list;
        }
    }
}
