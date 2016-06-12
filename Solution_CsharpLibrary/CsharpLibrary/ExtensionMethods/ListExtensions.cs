using System;
using System.Collections.Generic;
using System.Linq;

namespace CsharpLibrary.ExtensionMethods
{
    public static class ListExtensions
    {
        // Implementation of Fisher-Yates shuffle: https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle
        public static void Shuffle<T>(this IList<T> list, Random rng)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static IList<T> Clone<T>(this IList<T> listToClone)
        {
            var newList = new List<T>();
            foreach (var item in listToClone)
            {
                newList.Add(item);
            }
            return newList;
        }

        /// <summary>
        /// True if list contains any item that is also in list2
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        /// <returns></returns>
        public static bool ContainsAny<T>(this IEnumerable<T> list1, IEnumerable<T> list2)
        {
            var l2 = list2.ToList();
            foreach (var i in list1)
            {
                foreach (var j in l2)
                {
                    if (i.Equals(j))
                        return true;
                }
            }
            return false;
        }
    }
}
