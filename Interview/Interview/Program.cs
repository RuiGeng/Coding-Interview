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
            //QuestionOne();
            QuestionTwo();
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

        public static void QuestionTwo()
        {
            int[] i = new int[0];
            Console.WriteLine(i.Length);
            try
            {
                Console.WriteLine(i[0]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
