using System;

namespace Bridge
{
    public class FileOutput : Output
    {
        public override void Print(string value)
        {
            Console.WriteLine($"FileOutput ===> {value}");
        }
    }
}
