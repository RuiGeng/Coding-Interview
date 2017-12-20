namespace LintCode
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// http://www.cnblogs.com/libaoquan/p/7223043.html
    /// </summary>
    public class Code138
    {
        public static void SubArraySum1(int[] nums)
        {
            Dictionary<int, List<int>> newDictionary = new Dictionary<int, List<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                int sum = 0;
                List<int> indexList = new List<int>();
                sum = nums[i];
                newDictionary.Add(i, indexList);
                if (sum == 0)
                {
                    indexList.Add(i);
                    newDictionary[i] = indexList;
                }

                for (int j = i + 1; j < nums.Length; j++)
                {
                    sum += nums[j];
                    if (sum == 0)
                    {
                        indexList.Add(j);
                        newDictionary[i] = indexList;
                    }
                }
            }

            foreach (var d in newDictionary)
            {
                if (d.Value.Count > 0)
                {
                    Console.WriteLine($"Start Index = {d.Key}");
                    foreach (var i in d.Value)
                    {
                        Console.WriteLine($"End Index = {i}");
                    }
                }
            }
        }

        public static List<int> SubArraySum2(int[] nums)
        {
            int len = nums.Length;
            List<int> ans = new List<int>();
            Dictionary<int, int> data = new Dictionary<int, int> {{0, -1}};

            int sum = 0;
            for (int i = 0; i < len; i++)
            {
                sum += nums[i];

                if (data.ContainsKey(sum))
                {
                    ans.Add(data[sum] + 1);
                    ans.Add(i);
                    Console.WriteLine($"Start Index = {ans[0]}");
                    Console.WriteLine($"End Index = {ans[1]}");
                    return ans;
                }

                data.Add(sum, i);
            }

            return ans;
        }
    }
}