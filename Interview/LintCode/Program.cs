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
            string[] stringList = {"lint", "intl", "inlt", "code", "ab", "ba", "cd", "dc", "e"};
            foreach (var s in Code171.Anagrams(stringList))
            {
                Console.WriteLine(s);
            }
            //Console.WriteLine();
            Console.ReadLine();
        }
    }
}
