using System;

namespace AbstractFactory
{
    public class MacTextBox : TextBox
    {
        public override void Validate()
        {
            Console.WriteLine("Validate the macTextBox.");
        }
    }
}
