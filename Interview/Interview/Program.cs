﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Interview
{
    public class Program
    {
        public delegate string Delegate15(string str);

        public delegate void Delegate16(int num);

        public delegate void Delegate19(ref string str);

        private static void Main(string[] args)
        {
            //QuestionOne();
            //QuestionTwo();
            //QuestionThree();
            //QuestionFour();
            //QuestionFive();
            //QuestionSix();
            //QuestionSeven();
            //QuestionEight();
            //QuestionNine();
            //QuestionTen();
            //Question11();
            //Question12();
            //Question13();
            //Question14();
            //Question15();
            //Question16();
            //Question17();
            //Question18();
            //Question19();
            Question20();

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

        private class Person
        {
            public string Name { get; set; }

            public Person(string name)
            {
                Name = name;
            }
        }

        private static void PersonMethod(Person p)
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

        public static void QuestionTen()
        {
            int num1 = 20;
            int num2 = 30;

            var a = num1 ^ num2;
            Console.WriteLine(a);

            num1 ^= num2 ^= num1 ^= num2;
            Console.WriteLine(num1 + "," + num2);
        }

        public static void Question11()
        {
            char[] num = { '1', '2', '3' };
            Console.WriteLine(" char array: " + num);
        }

        public static void Question12()
        {
            ForQuestion12 forQuestion12 = null;
            Console.WriteLine(ForQuestion12.Print());
        }

        private class ForQuestion12
        {
            public static string Print()
            {
                return "Hi, I am a Tech-savvy!!";
            }
        }

        public static void Question13()
        {
            string[] strings = { "abc", "def", "ghi" };
            IList<Action> actions = new List<Action>();
            foreach (string str in strings)
                actions.Add(() => { Console.WriteLine(str); });

            foreach (var action in actions)
                action();
        }

        public static void Question14()
        {
            IList<Action> actions = new List<Action>();
            for (int i = 0; i < 4; i++)
            {
                actions.Add(() => Console.WriteLine(i));
            }
            foreach (var action in actions)
                action();
        }

        public class ForQuestion15
        {
            public static string DelegateSample(string a)
            {
                return a.Replace(',', '*');
            }
        }

        public static void Question15()
        {
            Delegate15 str1 = new Delegate15(ForQuestion15.DelegateSample);
            string str = str1("Welcome,,friends,,to,,TechBeamers");
            Console.WriteLine(str);
        }

        public class ForQuestion16
        {
            public void CheckEven(int num)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("This number is an even number");
                }
                else
                {
                    Console.WriteLine("This number is an odd number");
                }
            }

            public void SquareNumber(int num)
            {
                Console.WriteLine("Square of this number is: " + num * num);
            }
        }

        public static void Question16()
        {
            ForQuestion16 forQuestion16 = new ForQuestion16();
            Delegate16 delegate16 = new Delegate16(forQuestion16.CheckEven);
            delegate16 += new Delegate16(forQuestion16.SquareNumber);
            delegate16(25);
        }

        public static void Question17()
        {
            var arr = new List<int> { 20, 40, 35, 85, 70 };
            var collection = new Collection<int>(arr);
            arr.Add(60);
            arr.Sort();
            Console.WriteLine(string.Join(",", collection));
        }

        public static void Question18()
        {
            int? number = 0;
            int num = 1;
            Console.WriteLine(number.GetType());
            Console.WriteLine(number.GetType() == num.GetType());
        }

        public class ForQuestion19
        {
            public static void StringMarker(ref string a)
            {
                a = a.Substring(0, a.Length - 6);
            }
        }

        public static void Question19()
        {
            Delegate19 str1;
            string str = "Let's Learn CSharp";
            str1 = ForQuestion19.StringMarker;
            str1(ref str);
            Console.WriteLine(str);
        }

        public static void Question20()
        {
            bool a = true;
            bool b = false;

            // When one operand is true and the other is false, exclusive-OR 
            // returns True.
            Console.WriteLine(true ^ false);
            // When both operands are false, exclusive-OR returns False.
            Console.WriteLine(false ^ false);
            // When both operands are true, exclusive-OR returns False.
            Console.WriteLine(true ^ true);
            a ^= b;
            Console.WriteLine(a);
        }
    }
}