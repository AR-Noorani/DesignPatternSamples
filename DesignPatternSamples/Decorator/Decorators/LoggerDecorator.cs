using System;

namespace Decorator
{
    public class LoggerDecorator : Decorator
    {
        public LoggerDecorator(Service service) : base(service) { }

        public override void Operation()
        {
            Console.WriteLine($"Log: {service.GetType().Name} ===> Operation");
            base.Operation();
        }
    }
}
