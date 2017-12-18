namespace LintCode
{
    using System;
    using System.Collections.Generic;

    public class Code171
    {
        public static List<string> Anagrams(string[] stringList)
        {
            List<string> newList = new List<string>();
            Dictionary<string, List<string>> newDictionary = new Dictionary<string, List<string>>();
            foreach (var str in stringList)
            {
                var sortStr = SortString(str);
                if (newDictionary.ContainsKey(sortStr))
                {
                    newDictionary[sortStr].Add(str);
                }
                else
                {
                    newDictionary.Add(sortStr, new List<string>());
                    newDictionary[sortStr].Add(str);
                }
            }

            foreach (var d in newDictionary)
            {
                if (d.Value.Count > 1)
                {
                    newList.AddRange(d.Value);
                }
            }
            return newList;
        }

        private static string SortString(string str)
        {
            char[] characters = str.ToCharArray();
            Array.Sort(characters);
            return new string(characters);
        }
    }
}