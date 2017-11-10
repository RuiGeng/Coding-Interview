using System;
using System.Linq;

namespace Question1
{
    /// <summary>
    ///     Given an array of ints, write a C# method to total all the values that are even numbers.
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            var numbers = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            Console.WriteLine(@"The Count of even numbers is " + GetCountOfEvenNumbers(numbers));

            Console.WriteLine(@"The even numbers are");
            foreach (var number in GetEvenNumbers(numbers))
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            Console.WriteLine(@"The Total of even numbers is " + GetTotalOfEvenNumbers(numbers));

            Console.ReadLine();
        }

        public static int GetCountOfEvenNumbers(int[] numbers)
        {
            return numbers.Count(i => i % 2 == 0);
        }

        public static int[] GetEvenNumbers(int[] numbers)
        {
            return numbers.Where(i => i % 2 == 0).ToArray();
        }

        public static long GetTotalOfEvenNumbers(int[] numbers)
        {
            return numbers.Where(i => i % 2 == 0).Sum(i => (long)i);
        }
    }
}