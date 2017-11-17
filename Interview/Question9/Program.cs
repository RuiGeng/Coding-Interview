using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Question9
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "like for example $  you don't have $  network $  access";
            Regex rgx = new Regex("\\$\\s+");
            s = Regex.Replace(s, @"(\$\s+.*?)\$\s+", "$1$$");
            Console.WriteLine("string is: {0}", s);
        }
    }
}
