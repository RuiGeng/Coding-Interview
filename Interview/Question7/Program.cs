using System;
using System.Collections;
using System.Collections.Generic;

namespace Question7
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("A String");
            arrayList.Add(new Person("Rui", 100));

            foreach (var a in arrayList)
            {
                Console.WriteLine(a.GetType());

                if (a is Person)
                {
                    var person = a as Person;
                    Console.WriteLine(person.Name);
                    Console.WriteLine(person.Age);
                }
                else
                {
                    Console.WriteLine(a);
                }
            }

            List<object> objects = new List<object>();
            objects.Add(1);
            objects.Add("A String");
            objects.Add(new Person("Rui", 100));

            foreach (var o in objects)
            {
                Console.WriteLine(o.GetType());

                if (o is Person)
                {
                    var person = o as Person;
                    Console.WriteLine(person.Name);
                    Console.WriteLine(person.Age);
                }
                else
                {
                    Console.WriteLine(o);
                }
            }

            Console.ReadLine();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}