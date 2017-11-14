using System;
using System.Collections.Generic;

namespace Question6
{
    /// <summary>
    ///     Here’s why: The delegate is added in the for loop and “reference” (or perhaps “pointer” would be a better choice of
    ///     words) to i is stored, rather than the value itself. Therefore, after we exit the loop, the variable i has been set
    ///     to 10, so by the time each delegate is invoked, the value passed to all of them is 10.
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            var printers1 = new List<Printer>();
            var printers2 = new List<Printer>();

            for (int i = 0; i < 10; i++)
            {
                printers1.Add(() => { Console.WriteLine(i); });
            }

            foreach (var printer in printers1)
            {
                printer();
            }

            for (int i = 0; i < 10; i++)
            {
                var local = i;
                printers2.Add(() => { Console.WriteLine(local); });
            }

            foreach (var printer in printers2)
            {
                printer();
            }

            Console.ReadLine();
        }

        private delegate void Printer();
    }
}