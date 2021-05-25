using System;

namespace Proxy
{
    public class ProductServiceWithSecurity : Service
    {
        private readonly Lazy<ProductService> realSubject = new(() => new ProductService(), true);

        public override void Operation()
        {
            AuthorizeUser();
            realSubject.Value.Operation();
        }

        private void AuthorizeUser()
        {
            Console.WriteLine("ProductServiceWithSecurity ===> AuthorizeUser.");
        }
    }
}
