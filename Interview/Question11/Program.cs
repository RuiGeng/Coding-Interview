using System;

namespace Question11
{
    internal class Program
    {
        /// <summary>
        ///     The base keyword is used to call parent constructors
        ///     The this keyword is used to call other constructors, to initialize the class object. The following shows the
        ///     implementation:
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            var foo = new Person("ANaimi");
            // output:
            //  My name is ANaimi

            var bar = new Employee("ANaimi", "cook food");
            // output:
            //  My name is ANaimi
            //  I cook food for money.

            var baz = new Employee();
            // output:
            //  My name is Jeff
            //  I write code for money.
            //  I like cake.

            Console.ReadLine();
        }

        public class Person
        {
            public Person(string name)
            {
                Console.WriteLine("My name is " + name);
            }
        }

        public class Employee : Person
        {
            public Employee(string name, string job) : base(name)
            {
                Console.WriteLine("I " + job + " for money.");
            }

            public Employee(string name, string job, int age) : base(name)
            {
                Console.WriteLine("I " + job + " for money.");
            }

            public Employee() : this("Jeff", "write code")
            {
                Console.WriteLine("I like cake.");
            }
        }
    }
}