using System;

namespace Adapter
{
    public class MyTextBox : IControl
    {
        public void Render()
        {
            Console.WriteLine("TextBox ===> Render.");
        }
    }
}
