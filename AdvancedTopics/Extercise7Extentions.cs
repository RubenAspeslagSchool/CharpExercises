using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTopics
{
    public static class Extercise7Extentions
    {
        public static IEnumerable<T> WhereEx7<T>(this IEnumerable<T> list, Func<T,bool> filter)
        {
            foreach (T item in list)
            {
                if(filter(item)) yield return item;
            }
        }

        public static List<T> ToListEx7<T>(this IEnumerable<T> list)
        {
            List<T> result = new List<T>();
            foreach(T item in list)
            {
                result.Add(item);
            }
            return result;
        }

        public static void ForEachEx7<T>( this List<T>list ,Action<T> f )
        {
            foreach(T item in list) { f(item); }
        }

    }
}
