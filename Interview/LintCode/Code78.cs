namespace LintCode
{
    using System;

    public class Code78
    {
        public static string LongestCommonPrefix(string[] strings)
        {
            if (strings == null || strings.Length == 0)
            {
                return "";
            }

            if (strings.Length == 1)
            {
                return strings[0];
            }

            int commonPrefixLength = strings[0].Length;

            for (int i = 1; i < strings.Length; i++)
            {
                int length = Math.Min(strings[0].Length, strings[i].Length);

                if (length == 0)
                {
                    return "";
                }

                for (int j = 0; j < length; j++)
                {
                    if (strings[0][j] != strings[i][j])
                    {
                        if (j < commonPrefixLength)
                        {
                            commonPrefixLength = j;
                        }
                        break;
                    }
                }
            }
            return strings[0].Substring(0, commonPrefixLength);
        }
    }
}