using System;

namespace Bridge
{
    public class ConsoleOutput : Output
    {
        public override void Print(string value)
        {
            Console.WriteLine($"ConsoleOutput ===> {value}");
        }
    }
}
