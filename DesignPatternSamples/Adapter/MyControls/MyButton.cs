using System;

namespace Adapter
{
    public class MyButton : IControl
    {
        public void Render()
        {
            Console.WriteLine("Button ===> Render.");
        }
    }
}
