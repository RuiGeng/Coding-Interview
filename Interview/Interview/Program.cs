using System;

namespace Interview
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //QuestionOne();
            //QuestionTwo();
            //QuestionThree();
            //QuestionFour();
            //QuestionFive();
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

        public static void QuestionThree()
        {
            byte num = 100;
            dynamic val = num;
            Console.WriteLine(val.GetType());
            val += 100;
            Console.WriteLine(val.GetType());
        }

        public static void QuestionFour()
        {
#if (!pi)
            Console.WriteLine("i");
#else
            Console.WriteLine("PI undefined");
#endif
            Console.WriteLine("ok");
        }

        public static void QuestionFive()
        {
            int[] arr = new int[2];
            arr[1] = 10;
            Object o = arr;
            int[] arr1 = (int[]) o;
            arr1[1] = 100;
            Console.WriteLine(arr[1]);
            ((int[]) o)[1] = 1000;
            Console.WriteLine(arr[1]);
        }
    }
}