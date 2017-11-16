using System;

namespace Question8
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Class is a reference (pointer) type
            // reference (pointer) type can be null
            Person p = new Person("Rui", 100);

            Car c = new Car("Race Car", 200);

            ChangeValue(c, p);

            Console.WriteLine($@"Car type is  {c.Type}");

            Console.WriteLine($@"Person name is {p.Name}");

            Console.ReadLine();
        }

        public static void ChangeValue<T1, T2>(T1 t1, T2 t2) where T1 : ICar where T2 : IPerson
        {
            Console.WriteLine($@"Name before Change {t2.Name}");
            t2.Name = "Old Name";
            Console.WriteLine($@"Name after Change {t2.Name}");

            Console.WriteLine($@"Type before Change {t1.Type}");
            t1.Type = "Old Type";
            Console.WriteLine($@"Type after Change {t1.Type}");
        }
    }

    public interface IPerson
    {
        string Name { get; set; }
        int Age { get; set; }
    }

    /// <summary>
    /// Support inheritance
    /// Are reference(pointer) types
    /// The reference can be null
    /// Have memory overhead per new instance
    /// </summary>
    public class Person : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    public class Employee : Person
    {
        public int EmployeeNumber;

        public Employee(string name, int age, int employeeNumber) : base(name, age)
        {
            EmployeeNumber = employeeNumber;
        }
    }

    public interface ICar
    {
        string Type { get; set; }
        int Speed { get; set; }
    }

    /// <summary>
    /// Do not support inheritance
    /// Are value types
    /// Are passed by value(like integers)
    /// Cannot have a null reference(unless Nullable is used)
    /// Do not have memory overhead per new instance(unless “boxed”)
    /// </summary>
    public struct Car : ICar
    {
        public string Type { get; set; }
        public int Speed { get; set; }

        public Car(string type, int speed)
        {
            Type = type;
            Speed = speed;
        }
    }
}