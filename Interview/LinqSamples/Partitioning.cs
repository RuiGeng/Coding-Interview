using System;
using System.Collections.Generic;
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

        public static void Take2()
        {
            List<Customer> customers = Customer.GetCustomerList();

            var first3WAOrders =
                customers.Where(c => c.Region == "WA")
                .SelectMany(
                    c => c.Orders,
                    (customer, order) => new { customer.CustomerId, order.OrderId, order.OrderDate })
                .Take(3);

            Console.WriteLine("LinqSamples Take2");

            foreach (var order in first3WAOrders)
            {
                Console.WriteLine(order);
            }
        }

        public static void Take2_()
        {
            List<Customer> customers = Customer.GetCustomerList();

            var first3WAOrders =
                (from customer in customers
                 from o in customer.Orders
                 where customer.Region == "WA"
                 select new { customer.CustomerId, o.OrderId, o.OrderDate }).Take(3);

            Console.WriteLine("LinqSamples Take2_");

            foreach (var order in first3WAOrders)
            {
                Console.WriteLine(order);
            }
        }

        public static void Skip1()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var allButFirst4Numbers = numbers.Skip(4);

            Console.WriteLine("LinqSamples Skip1");

            foreach (var n in allButFirst4Numbers)
            {
                Console.WriteLine(n);
            }
        }

        public static void Skip2()
        {
            List<Customer> customers = Customer.GetCustomerList();

            var allButFirst2Orders = customers.Where(c => c.Region == "WA").SelectMany(c => c.Orders,
                (customer, order) => new { customer.CustomerId, order.OrderId, order.OrderDate }).Skip(2);

            Console.WriteLine("LinqSamples Skip2");

            foreach (var order in allButFirst2Orders)
            {
                Console.WriteLine(order);
            }
        }

        public static void Skip2_()
        {
            List<Customer> customers = Customer.GetCustomerList();

            var allButFirst2Orders =
                (from customer in customers
                 where customer.Region == "WA"
                 from order in customer.Orders
                 select new { customer.CustomerId, order.OrderId, order.OrderDate }).Skip(2);

            Console.WriteLine("LinqSamples Skip2_");

            foreach (var order in allButFirst2Orders)
            {
                Console.WriteLine(order);
            }
        }
    }
}