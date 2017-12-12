using System;
using System.Linq;

namespace LintCode
{
    public class Code158
    {
        public static bool Anagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            var sortedS = SortString2(s);
            var sortedT = SortString2(t);
            if (string.CompareOrdinal(sortedS, sortedT) == 0)
            {
                return true;
            }

            return false;
        }

        private static string SortString1(string s)
        {
            char[] characters = s.ToCharArray();
            Array.Sort(characters);
            return new string(characters);
        }

        private static string SortString2(string s)
        {
            return string.Concat(s.OrderBy(c => c));
        }

    }
}