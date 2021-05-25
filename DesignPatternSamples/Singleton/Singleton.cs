using System;

namespace Singleton
{
    public class Singleton
    {
        private static readonly Lazy<Singleton> _instance = new(() => new Singleton(), true);
        public static Singleton Instance => _instance.Value;

        private Guid ID = Guid.NewGuid();        

        private Singleton() { }

        public void Operation()
        {
            Console.WriteLine($"Singleton({ID}) ===> Operation");
        }
    }
}
