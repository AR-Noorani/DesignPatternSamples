namespace Decorator
{
    public abstract class Decorator : Service
    {
        protected Service service;

        public Decorator(Service service)
        {
            this.service = service;
        }

        public override void Operation()
        {
            service.Operation();
        }
    }
}
