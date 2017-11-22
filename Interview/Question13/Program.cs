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
            Client client = new Client(new Service());
            client.Start();
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

        public class Client
        {
            private readonly IService service;

            public Client(IService service)
            {
                this.service = service;
            }

            public void Start()
            {
                Console.WriteLine("Service Started");
                service.Serve();
            }
        }
    }
}