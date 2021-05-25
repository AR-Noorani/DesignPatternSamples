using System;

namespace AbstractFactory
{
    public class WinTextBox : TextBox
    {
        public override void Validate()
        {
            Console.WriteLine("Validate the winTextBox.");
        }
    }
}
