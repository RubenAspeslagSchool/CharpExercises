using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTopics
{
    public static class Exercise5
    {
        public static IEnumerable<char> Reverse(this string text,bool keepspaces = true)
        {
            for (int i = text.Length - 1; i >= 0; i--)
            {
                if (!(keepspaces && text[i] == ' '))
                {
                    yield return text[i];
                }
            }
        }

        public static string ConvertToString(this IEnumerable<char>text )
        {
            return String.Concat(text);
        }

        public static bool IsOdd(this int x)
        {
            return !(x % 2 == 0);
        }

        public static int CountChar(this String text, char c)
        {
            int count = 0;
            foreach (char ch in text) 
            {
                if (ch == c)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
