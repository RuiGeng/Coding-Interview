using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LintCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] A = { "a", "a", "aa", "abba", "aa" };

            Console.WriteLine(Code78.LongestCommonPrefix(A));
            Console.ReadLine();
        }
    }
}
