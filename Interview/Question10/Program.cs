using System;
using System.Threading;

namespace Question10
{
    /// <summary>
    ///     A static constructor is used to initialize any static data, or to perform a particular action that needs to be
    ///     performed once only. It is called automatically before the first instance is created or any static members are
    ///     referenced.
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            Thread.Sleep(5000);
            var t = new TestStatic();
            t.Print();
            Console.ReadLine();
        }
    }

    public class TestStatic
    {
        public static int TestValue;
        public static DateTime TestTime;

        static TestStatic()
        {
            if (TestValue == 0)
                TestValue = 10;

            TestTime = DateTime.Now;
        }

        public TestStatic()
        {
            if (TestValue == 0)
                TestValue = 5;
        }

        public void Print()
        {
            if (TestValue == 5)
                TestValue = 6;

            Console.WriteLine("Init Time  : " + TestTime);
            Console.WriteLine("TestValue : " + TestValue);
        }
    }
}