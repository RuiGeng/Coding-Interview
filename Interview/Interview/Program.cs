using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            QuestionOne();
            Console.ReadLine();
        }

        /// <summary>
        /// If the fractional component of a is halfway between two integers, one of which is even
        /// and the other odd, then the even number is returned. Note that this method returns a
        /// Double instead of an integral type.
        /// </summary>
        public static void QuestionOne()
        {
            Console.WriteLine(Math.Round(6.5));
            Console.WriteLine(Math.Round(11.5));
        }
    }
}
