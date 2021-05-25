using System;

namespace AbstractFactory
{
    public class MacButton : Button
    {
        public override void Press()
        {
            Console.WriteLine("Press the macButton.");
        }
    }
}
