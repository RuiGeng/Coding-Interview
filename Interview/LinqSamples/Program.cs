using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqSamples
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Where1();
            Where2_();
            Console.ReadLine();
        }

        public static void Where1()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var newNumbers = numbers.Where(i => i < 5);

            Console.WriteLine("LinqSamples Where1");
            foreach (var n in newNumbers)
            {
                Console.WriteLine(n);
            }
        }

        public static void Where1_()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var newNumbers =
                from n in numbers
                where n < 5
                select n;

            Console.WriteLine("LinqSamples Where1_");
            foreach (var n in newNumbers)
            {
                Console.WriteLine(n);
            }
        }

        public static void Where2()
        {
            List<Product> products = Product.GetProductList();

            var soldOutProducts = products.Where(p => p.UnitsInStock <= 0);

            Console.WriteLine("LinqSamples Where2");
            foreach (var sp in soldOutProducts)
            {
                Console.WriteLine(sp.ProductName);
            }
        }

        public static void Where2_()
        {
            List<Product> products = Product.GetProductList();

            var soldOutProducts =
                from p in products
                where p.UnitsInStock <= 0
                select p;

            Console.WriteLine("LinqSamples Where2_");
            foreach (var sp in soldOutProducts)
            {
                Console.WriteLine(sp.ProductName);
            }
        }
    }
}