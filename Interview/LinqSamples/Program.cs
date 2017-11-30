using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqSamples
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Where4();
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
        public static void Where3()
        {
            List<Product> products = Product.GetProductList();

            var soldOutProducts = products.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3);

            Console.WriteLine("LinqSamples Where3");
            foreach (var sp in soldOutProducts)
            {
                Console.WriteLine(sp.ProductName);
            }
        }

        public static void Where3_()
        {
            List<Product> products = Product.GetProductList();

            var soldOutProducts =
                from p in products
                where p.UnitsInStock > 0 && p.UnitPrice > 3
                select p;

            Console.WriteLine("LinqSamples Where3_");
            foreach (var sp in soldOutProducts)
            {
                Console.WriteLine(sp.ProductName);
            }
        }

        public static void Where4()
        {
            List<Customer> customers = Customer.GetCustomerList();

            var waCustomers = customers.Where(c => c.Region == "WA");

            Console.WriteLine("LinqSamples Where4");
            foreach (var customer in waCustomers)
            {
                Console.WriteLine("Customer {0}: {1}", customer.CustomerId, customer.CompanyName);
                foreach (var order in customer.Orders)
                {
                    Console.WriteLine("  Order {0}: {1}", order.OrderId, order.OrderDate);
                }
            }
        }

        public static void Where5()
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var shortDigits = digits.Where((digit, index) => digit.Length < index);
            Console.WriteLine("LinqSamples Where5");
            foreach (var d in shortDigits)
            {
                Console.WriteLine(d);
            }
        }

        public static void Where5_()
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var shortDigits = 
                from d in digits.Select((digit, index) => new {digit, index})
                where d.digit.Length < d.index
                select d.digit;

            Console.WriteLine("LinqSamples Where5_");
            foreach (var d in shortDigits)
            {
                Console.WriteLine(d);
            }
        }
    }
}