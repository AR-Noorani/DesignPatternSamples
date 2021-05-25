using System;

namespace AbstractFactory
{
    public class WinButton : Button
    {
        public override void Press()
        {
            Console.WriteLine("Press the winButton.");
        }
    }
}
