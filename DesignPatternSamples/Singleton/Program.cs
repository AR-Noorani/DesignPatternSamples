using System;

namespace Singleton
{
    class Program
    {
        static void Main()
        {
            Singleton.Instance.Operation();
            Singleton.Instance.Operation();

            Console.ReadKey();
        }
    }
}
