using System;

namespace Decorator
{
    class Program
    {
        static void Main()
        {
            var customerService = new CustomerService();
            customerService.Operation();
            Console.WriteLine();

            var loggerDecorator = new LoggerDecorator(customerService);
            loggerDecorator.Operation();
            Console.WriteLine();

            var eventDecorator = new EventDecorator(loggerDecorator);
            eventDecorator.OperationInvoking += EventDecorator_Before;
            eventDecorator.OperationInvoked += EventDecorator_After; ;
            eventDecorator.Operation();
            Console.WriteLine();

            Console.ReadKey();
        }

        private static void EventDecorator_Before(object sender, EventArgs e)
        {
            Console.WriteLine("Operation Invoking");
        }

        private static void EventDecorator_After(object sender, EventArgs e)
        {
            Console.WriteLine("Operation Invoked");
        }
    }
}
