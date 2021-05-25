using System;

namespace Decorator
{
    public class CustomerService : Service
    {
        public override void Operation()
        {
            Console.WriteLine("Operation...");
        }
    }
}
