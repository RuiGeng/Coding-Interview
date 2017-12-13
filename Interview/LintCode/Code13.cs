namespace LintCode
{
    public class Code13
    {
        /// <summary>
        /// Returns a index to the first occurrence of target in source,
        /// or -1  if target is not part of source.
        /// @param source string to be scanned.
        /// @param target string containing the sequence of characters to match.
        /// </summary>
        /// <param name="source">source string</param>
        /// <param name="target">target string</param>
        /// <returns>index</returns>
        public static int StrStr(string source, string target)
        {
            if (string.IsNullOrEmpty(source) || string.IsNullOrEmpty(target))
            {
                return -1;
            }

            int sourceLength = source.Length;
            int targetLength = target.Length;

            for (int i = 0; i < sourceLength - targetLength + 1; i++)
            {
                int j;
                for (j = 0; j < targetLength; j++)
                {
                    if (source[i + j] != target[j])
                    {
                        break;
                    }
                }
                if (j == targetLength)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}