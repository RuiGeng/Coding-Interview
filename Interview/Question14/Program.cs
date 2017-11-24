using System;

namespace Question14
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(KmToMeters(Console.ReadLine()));
            }
        }

        public static long? KmToMeters(string kilometers)
        {
            try
            {
                var k = Convert.ToDouble(kilometers);

                if (k < 0)
                {
                    throw new Exception("invalid input");
                }

                return (long)(k * 1000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return null;
        }
    }
}