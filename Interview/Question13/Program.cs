using System;

namespace Question13
{
    /// <summary>
    /// http://www.dotnettricks.com/learn/dependencyinjection/implementation-of-dependency-injection-pattern-in-csharp
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            //1. Constructor Injection
            Client1 client1 = new Client1(new Service());
            client1.Start();

            //2. Property injection
            Client2 client2 = new Client2
            {
                Service = new Service()
            };
            client2.Start();

            //3. Method injection
            Client3 client3 = new Client3();
            client3.Start(new Service());

            Console.ReadLine();
        }

        public interface IService
        {
            void Serve();
        }

        public class Service : IService
        {
            public void Serve()
            {
                Console.WriteLine("Service Called");
            }
        }

        public class Client1
        {
            private readonly IService service;

            public Client1(IService service)
            {
                this.service = service;
            }

            public void Start()
            {
                Console.WriteLine("Service Started");
                service.Serve();
            }
        }

        public class Client2
        {
            private IService service;

            public IService Service
            {
                get { return service; }
                set { this.service = value; }
            }

            public void Start()
            {
                Console.WriteLine("Service Started");
                service.Serve();
            }
        }

        public class Client3
        {
            public void Start(IService service)
            {
                Console.WriteLine("Service Started");
                service.Serve();
            }
        }
    }
}