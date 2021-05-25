using System;

namespace FactoryMethod
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circle.");
        }
    }
}
