using System;

namespace Proxy
{
    class Program
    {
        static void Main()
        {
            Service service = new ProductService();
            service.Operation();
            Console.WriteLine();

            service = new ProductServiceWithSecurity();
            service.Operation();

            Console.ReadKey();
        }
    }
}
