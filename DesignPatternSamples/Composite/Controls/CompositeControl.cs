using System;
using System.Collections.Generic;

namespace Composite
{
    public abstract class CompositeControl : Control
    {
        public List<Control> Controls { get; init; }

        public CompositeControl(string name) : base(name)
        {
            Controls = new List<Control>();
        }

        public override void Add(Control component)
        {
            Controls.Add(component);
        }

        public override void Remove(Control component)
        {
            Controls.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);

            foreach (var component in Controls)
                component.Display(depth + 2);
        }
    }
}
