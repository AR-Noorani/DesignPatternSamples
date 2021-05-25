using System;

namespace Proxy
{
    public class ProductService : Service
    {
        public override void Operation()
        {
            Console.WriteLine("ProductService ===> Operation.");
        }
    }
}
