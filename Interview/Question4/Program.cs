using System;

namespace Question4
{
    /// <summary>
    ///     write code to calculate the circumference of the circle, without modifying the Circle class itself.
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            Func<double, double> func = d => 2 * Math.PI * d;
            var circle = new Circle();
            Console.WriteLine(circle.Calculate(func));
            Console.WriteLine(circle.Calculate(r => r * Math.PI * r));
            Console.ReadLine();
        }
    }

    public sealed class Circle
    {
        private double radius;

        public double Calculate(Func<double, double> op)
        {
            return op(radius);
        }
    }
}