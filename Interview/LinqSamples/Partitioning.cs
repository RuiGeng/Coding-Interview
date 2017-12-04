using System;
using System.Linq;

namespace LinqSamples
{
    public class Partitioning
    {
        public static void Take1()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var first3Numbers = numbers.Take(3);

            Console.WriteLine("LinqSamples Take1");

            foreach (var n in first3Numbers)
            {
                Console.WriteLine(n);
            }

        }
    }
}