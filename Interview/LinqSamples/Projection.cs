using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqSamples
{
    public class Projection
    {
        private static int odd;

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

        public static void Select3()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var textNums = numbers.Select(i => strings[i]);
            Console.WriteLine("Select3");
            foreach (var tn in textNums)
            {
                Console.WriteLine(tn);
            }
        }

        public static void Select3_()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var textNums =
                from n in numbers
                select strings[n];

            Console.WriteLine("Select3_");
            foreach (var tn in textNums)
            {
                Console.WriteLine(tn);
            }
        }

        public static void Select4()
        {
            string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            var upperLowerWords = words.Select(w => new { ToUpper = w.ToUpper(), ToLower = w.ToLower() });

            Console.WriteLine("Select4");
            foreach (var ul in upperLowerWords)
            {
                Console.WriteLine($@"Uppercase: {ul.ToUpper}, Lowercase: {ul.ToLower}");
            }
        }

        public static void Select4_()
        {
            string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            var upperLowerWords =
                from word in words
                select new { ToUpper = word.ToUpper(), ToLower = word.ToLower() };

            Console.WriteLine("Select4_");
            foreach (var ul in upperLowerWords)
            {
                Console.WriteLine($@"Uppercase: {ul.ToUpper}, Lowercase: {ul.ToLower}");
            }
        }

        public static void Select5()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var digitOddEvens =
                numbers.Select((n, index) => new { Digit = strings[n], isEven = n % 2 == 0, Index = index });

            Console.WriteLine("Select5");
            foreach (var d in digitOddEvens)
            {
                var oddEven = d.isEven ? "even" : "odd";
                Console.WriteLine($@"The digit {d.Digit} is {oddEven} and index is {d.Index}");
            }
        }

        public static void Select5_()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var digitOddEvens =
                from i in numbers.Select((n, index) => new { Number = n, Index = index })
                select new { Digit = strings[i.Number], isEven = i.Number % 2 == 0, Index = i.Index };

            Console.WriteLine("Select5_");
            foreach (var d in digitOddEvens)
            {
                var oddEven = d.isEven ? "even" : "odd";
                Console.WriteLine($@"The digit {d.Digit} is {oddEven} and index is {d.Index}");
            }
        }

        public static void Select6()
        {
            List<Product> products = Product.GetProductList();

            var productInfos = products.Select(p =>
                new {p.ProductName, p.Category, Price = p.UnitPrice });

            Console.WriteLine("Select6");
            foreach (var productInfo in productInfos)
            {
                Console.WriteLine($@"{productInfo.ProductName} is in the category {productInfo.Category} and costs {productInfo.Price} per unit.");
            }
        }

        public static void Select6_()
        {
            List<Product> products = Product.GetProductList();

            var productInfos =
                from product in products
                select new {product.ProductName, product.Category, Price = product.UnitPrice};

            Console.WriteLine("Select6_");
            foreach (var productInfo in productInfos)
            {
                Console.WriteLine($@"{productInfo.ProductName} is in the category {productInfo.Category} and costs {productInfo.Price} per unit.");
            }
        }
    }
}