using System;

namespace LintCode
{
    using System.Collections.Generic;

    public class Code138
    {
        public static void SubarraySum(int[] nums)
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
    }
}