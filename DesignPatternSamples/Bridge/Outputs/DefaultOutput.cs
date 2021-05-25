using System;

namespace Bridge
{
    public class DefaultOutput : Output
    {
        public override void Print(string value)
        {
            Console.WriteLine($"DefaultOutput ===> {value}");
        }
    }
}
