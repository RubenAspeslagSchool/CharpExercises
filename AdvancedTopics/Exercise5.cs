using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTopics
{
    public static class Exercise5
    {
        public static IEnumerable<char> Reverse(this string text,bool keepspaces)
        {
            for (int i = text.Length - 1; i >= 0; i--)
            {
                yield return text[i];
            }
        }

        public static string ConvertToString(this IEnumerable<char>text )
        {
            return String.Concat(text);
        }
    }
}
