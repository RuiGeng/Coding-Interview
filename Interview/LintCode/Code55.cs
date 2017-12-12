using System.Collections.Generic;

namespace LintCode
{
    public class Code55
    {
        public static bool CompareStrings(string A, string B)
        {
            Dictionary<char, int> stringDictionary = new Dictionary<char, int>();

            foreach (var c in A.ToUpper())
            {
                if (!stringDictionary.ContainsKey(c))
                {
                    stringDictionary.Add(c, 1);
                }
                else
                {
                    stringDictionary[c]++;
                }
            }

            foreach (var c in B.ToUpper())
            {
                if (!stringDictionary.ContainsKey(c) || stringDictionary[c] == 0)
                {
                    return false;
                }

                stringDictionary[c]--;
            }

            return true;
        }
    }
}