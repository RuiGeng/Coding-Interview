using System;

namespace Question15
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var b = Boxing(123);

            var ub = Unboxing<int>(b);

            Console.ReadLine();
        }

        public static object Boxing<T>(T t)
        {
            var o = Convert.ChangeType(t, typeof(object));
            return o;
        }

        public static TType Unboxing<TType>(object o)
        {
            var returnValue = Convert.ChangeType(o, typeof(TType));
            return (TType)returnValue;
        }
    }
}