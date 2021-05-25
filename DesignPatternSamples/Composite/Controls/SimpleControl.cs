using System;

namespace Composite
{
    public abstract class SimpleControl : Control
    {
        public SimpleControl(string name) : base(name) { }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
        }
    }
}
