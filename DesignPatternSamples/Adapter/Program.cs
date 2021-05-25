using System;

namespace Adapter
{
    class Program
    {
        static void Main()
        {
            IControl target = new MyTextBox();
            target.Render();

            target = new MyButton();
            target.Render();

            target = new ObjectAdapter.MyTextArea();
            target.Render();

            target = new ClassAdapter.MyTextArea();
            target.Render();

            Console.ReadKey();
        }
    }
}
