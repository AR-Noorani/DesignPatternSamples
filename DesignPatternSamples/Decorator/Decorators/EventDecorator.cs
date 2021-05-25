using System;

namespace Decorator
{
    public class EventDecorator : Decorator
    {
        public event EventHandler<EventArgs> OperationInvoking;
        public event EventHandler<EventArgs> OperationInvoked;

        public EventDecorator(Service service) : base(service) { }

        public override void Operation()
        {
            OperationInvoking?.Invoke(this, EventArgs.Empty);
            base.Operation();
            OperationInvoked?.Invoke(this, EventArgs.Empty);
        }
    }
}
