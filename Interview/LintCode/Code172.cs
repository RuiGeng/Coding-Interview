using System;
using System.Collections.Generic;

namespace LintCode
{
    public class Code172
    {
        public static int RemoveElement(int[] intArray, int elem)
        {
            int num = 0;
            int len = intArray.Length;

            for (int i = 0; i < len; i++)
            {
                if (intArray[i] != elem)
                {
                    intArray[num] = intArray[i];
                    ++num;
                }
            }
            return num;
        }
    }
}