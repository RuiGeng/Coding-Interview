namespace LintCode
{
    using System;
    /// <summary>
    /// https://songlee24.github.io/2015/03/18/hua-wei-OJ2011/
    /// http://blog.csdn.net/u010002184/article/details/50740691
    /// </summary>
    public class Code79
    {
        public static int LongestCommonSubstring(string A, string B)
        {
            int aLength = A.Length;
            int bLength = B.Length;
            int[,] dp = new int[aLength + 1, bLength + 1];
            int num = 0;

            for (int i = 1; i <= aLength; i++)
            {
                char c1 = A[i - 1];
                for (int j = 1; j <= bLength; j++)
                {
                    char c2 = B[j - 1];
                    if (c1 == c2)
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        dp[i, j] = 0;
                    }
                    num = Math.Max(num, dp[i, j]);
                }
            }
            return num;
        }
    }
}