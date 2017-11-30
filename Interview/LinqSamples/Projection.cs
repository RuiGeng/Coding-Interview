﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqSamples
{
    public class Projection
    {
        public static void Select1()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var numsPlusOne = numbers.Select(n => n + 1);

            Console.WriteLine("LinqSamples Select1");
            foreach (var i in numsPlusOne)
            {
                Console.WriteLine(i);
            }
        }

        public static void Select1_()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var numsPlusOne =
                from n in numbers
                select n + 1;

            Console.WriteLine("LinqSamples Select1_");
            foreach (var i in numsPlusOne)
            {
                Console.WriteLine(i);
            }
        }

        public static void Select2()
        {
            List<Product> products = Product.GetProductList();

            var productNames = products.Select(p => p.ProductName);

            Console.WriteLine("LinqSamples Select2");
            foreach (var pn in productNames)
            {
                Console.WriteLine(pn);
            }
        }

        public static void Select2_()
        {
            List<Product> products = Product.GetProductList();

            var productNames =
                from product in products
                select product.ProductName;

            Console.WriteLine("LinqSamples Select2_");
            foreach (var pn in productNames)
            {
                Console.WriteLine(pn);
            }
        }
    }
}