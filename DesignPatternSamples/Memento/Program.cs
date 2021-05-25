using System;

namespace Memento
{
    class Program
    {
        static void Main()
        {
            var originator1 = new Originator("s1", "s2");
            var memento = originator1.Backup();

            Console.WriteLine($"originator1.state2={originator1.state2}");

            var originator2 = new Originator();
            originator2.Restore(memento);

            Console.WriteLine($"originator2.state2={originator2.state2}");

            Console.ReadKey();
        }
    }
}
