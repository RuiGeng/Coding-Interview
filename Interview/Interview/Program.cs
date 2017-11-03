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
            //QuestionSix();
            //QuestionSeven();
            QuestionEight();


            //Person p = new Person("Jack");
            //PersonMethod(p);
            //Console.WriteLine(p.Name);

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
            object o = arr;
            int[] arr1 = (int[])o;
            arr1[1] = 100;
            Console.WriteLine(arr[1]);
            ((int[])o)[1] = 1000;
            Console.WriteLine(arr[1]);
        }

        public static void QuestionSix()
        {
            string a = "TechBeamers";
            string b = "TECHBEAMERS";
            int c = a.CompareTo(b);
            Console.WriteLine(c);
        }

        public static void ArrayMethod(int[] a)
        {
            int[] b = new int[5];
            a = b;
            Console.WriteLine(a.Length);
            Console.WriteLine(b.Length);
        }

        public static void QuestionSeven()
        {
            int[] arr = new int[10];
            ArrayMethod(arr);
            Console.WriteLine(arr.Length);
        }


        class Person
        {
            public string Name { get; set; }
            public Person(string name)
            {
                Name = name;
            }
        }

        static void PersonMethod(Person p)
        {
            Person p1 = new Person("Tom");
            p = p1;
            Console.WriteLine(p.Name);
            Console.WriteLine(p1.Name);
            p.Name = "Peter";
            Console.WriteLine(p.Name);
            Console.WriteLine(p1.Name);
        }

        public static void QuestionEight()
        {
            PrintQuestionEight(2, 3, 8);
            int[] arr = { 2, 11, 15, 20 };
            PrintQuestionEight(arr);
        }

        public static void PrintQuestionEight(params int[] b)
        {
            foreach (var i in b)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public static void QuestionNine()
        {
            char x = 'A';
            int i = 0;
            Console.WriteLine(true ? x : 0);
            Console.WriteLine(false ? i : x);
        }
    }
}