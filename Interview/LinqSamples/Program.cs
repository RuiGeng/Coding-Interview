using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Where1();
            Console.ReadLine();
        }

        public static void Where1()
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            var newNumbers = numbers.Where(i => i < 5);
            foreach (var n in newNumbers)
            {
                Console.WriteLine("LinqSamples Where1");
                Console.WriteLine(n);
            }
        }
    }
}
