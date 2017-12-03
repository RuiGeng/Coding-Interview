using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

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
                new { p.ProductName, p.Category, Price = p.UnitPrice });

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
                select new { product.ProductName, product.Category, Price = product.UnitPrice };

            Console.WriteLine("Select6_");
            foreach (var productInfo in productInfos)
            {
                Console.WriteLine($@"{productInfo.ProductName} is in the category {productInfo.Category} and costs {productInfo.Price} per unit.");
            }
        }

        public static void Select7()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var numsInPlace = numbers.Select((n, index) => new { Number = n, IsSameAsIndex = n == index, Index = index });

            var newNumbers = numbers.Where((n, index) => n == index);

            Console.WriteLine("Select7");
            foreach (var n in numsInPlace)
            {
                Console.WriteLine($@"{n.Number}: {n.IsSameAsIndex}, {n.Index}");
            }

            foreach (var n in newNumbers)
            {
                Console.WriteLine(n);
            }
        }

        public static void Select7_()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var numsInPlace =
                from newNumberList in numbers.Select((n, index) => new { Number = n, Index = index })
                select new
                {
                    newNumberList.Number,
                    IsSameAsIndex = newNumberList.Number == newNumberList.Index,
                    newNumberList.Index
                };

            var newNumbers = numbers.Where((n, index) => n == index);

            Console.WriteLine("Select7_");
            foreach (var n in numsInPlace)
            {
                Console.WriteLine($@"{n.Number}: {n.IsSameAsIndex}, {n.Index}");
            }

            foreach (var n in newNumbers)
            {
                Console.WriteLine(n);
            }
        }

        public static void Select8()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var lowNums = numbers.Where(n => n < 5).Select((n, index) => new { Number = n, Text = digits[n], Index = index });

            Console.WriteLine("Select8");
            foreach (var num in lowNums)
            {
                Console.WriteLine(num);
            }
        }

        public static void Select8_()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var lowNums =
                from n in numbers.Select((n, index) => new { Number = n, Index = index })
                where n.Number < 5
                select new { n.Number, Text = digits[n.Number], n.Index };

            Console.WriteLine("Select8_");
            foreach (var num in lowNums)
            {
                Console.WriteLine(num);
            }
        }

        public static void SelectMany1()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            var pairs = numbersA.SelectMany(a => numbersB.Where(b => a < b), (nA, nB) => new { a = nA, b = nB });

            Console.WriteLine("SelectMany1");
            foreach (var pair in pairs)
            {
                Console.WriteLine("{0} is less than {1}", pair.a, pair.b);
            }
        }

        public static void SelectMany1_()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            var pairs =
                from a in numbersA
                from b in numbersB
                where a < b
                select new { a, b };

            Console.WriteLine("SelectMany1_");
            foreach (var pair in pairs)
            {
                Console.WriteLine("{0} is less than {1}", pair.a, pair.b);
            }
        }

        public static void SelectMany2()
        {
            List<Customer> customers = Customer.GetCustomerList();

            var orders = customers.SelectMany(c => c.Orders.Where(o => o.Total < 500), (c, o) => new { c.CustomerId, o.OrderId, o.Total });

            Console.WriteLine("SelectMany2");
            foreach (var order in orders)
            {
                Console.WriteLine(order);
            }
        }

        public static void SelectMany2_()
        {
            List<Customer> customers = Customer.GetCustomerList();

            var orders =
                from customer in customers
                from order in customer.Orders
                where order.Total < 500.00M
                select new { customer.CustomerId, order.OrderId, order.Total };

            Console.WriteLine("SelectMany2_");
            foreach (var order in orders)
            {
                Console.WriteLine(order);
            }
        }

        public static void SelectMany3()
        {
            List<Customer> customers = Customer.GetCustomerList();

            var orders = customers.SelectMany(
                customer => customer.Orders.Where(order => order.OrderDate > new DateTime(1998, 1, 1)),
                (customer, order) => new { customer.CustomerId, order.OrderId, order.OrderDate });

            Console.WriteLine("SelectMany3");
            foreach (var order in orders)
            {
                Console.WriteLine(order);
            }
        }

        public static void SelectMany3_()
        {
            List<Customer> customers = Customer.GetCustomerList();

            var orders =
                from customer in customers
                from order in customer.Orders
                where order.OrderDate > new DateTime(1998, 1, 1)
                select new { customer.CustomerId, order.OrderId, order.OrderDate };

            Console.WriteLine("SelectMany3_");
            foreach (var order in orders)
            {
                Console.WriteLine(order);
            }
        }

        public static void SelectMany4()
        {
            List<Customer> customers = Customer.GetCustomerList();

            var orders = customers.SelectMany(c => c.Orders.Where(o => o.Total > 2000.0M),
                (c, o) => new { c.CustomerId, o.OrderId, o.Total });

            Console.WriteLine("SelectMany4");
            foreach (var order in orders)
            {
                Console.WriteLine(order);
            }
        }

        public static void SelectMany4_()
        {
            List<Customer> customers = Customer.GetCustomerList();

            var orders =
                from customer in customers
                from order in customer.Orders
                where order.Total > 2000.0M
                select new { customer.CustomerId, order.OrderId, order.Total };

            Console.WriteLine("SelectMany4_");
            foreach (var order in orders)
            {
                Console.WriteLine(order);
            }
        }
        public static void SelectMany5()
        {
            List<Customer> customers = Customer.GetCustomerList();

            var orders = customers.Where(c => c.Region == "WA")
                .SelectMany(c => c.Orders.Where(o => o.OrderDate > new DateTime(1997, 1, 1)),
                (c, o) => new { c.CustomerId, o.OrderId });

            Console.WriteLine("SelectMany5");
            foreach (var order in orders)
            {
                Console.WriteLine(order);
            }
        }

        public static void SelectMany5_()
        {
            List<Customer> customers = Customer.GetCustomerList();

            var orders =
                from customer in customers
                where customer.Region == "WA"
                from order in customer.Orders
                where order.OrderDate > new DateTime(1997, 1, 1)
                select new { customer.CustomerId, order.OrderId };

            Console.WriteLine("SelectMany5_");
            foreach (var order in orders)
            {
                Console.WriteLine(order);
            }
        }

        public static void SelectMany6()
        {
            List<Customer> customers = Customer.GetCustomerList();

            var customerOrders = customers.SelectMany((customer, custIndex) =>
                customer.Orders.Select(o => "Customer #" + (custIndex + 1) +
                                                            " has an order with OrderID " + o.OrderId));

            Console.WriteLine("SelectMany6");
            foreach (var order in customerOrders)
            {
                Console.WriteLine(order);
            }
        }

        public static void SelectMany6_()
        {
            List<Customer> customers = Customer.GetCustomerList();

            var customerOrders =
                from customer in customers.Select((c, i) => new {Cust = c, Index = i})
                from o in customer.Cust.Orders
                select "Customer #" + (customer.Index + 1) +
                       " has an order with OrderID " + o.OrderId;

            Console.WriteLine("SelectMany6_");
            foreach (var order in customerOrders)
            {
                Console.WriteLine(order);
            }
        }
    }
}