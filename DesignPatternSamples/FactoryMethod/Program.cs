using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main()
        {
            var circle = Factory.FactoryMethod("Circle");
            circle.Draw();

            var rectangle = Factory.FactoryMethod("Rectangle");
            rectangle.Draw();

            Console.ReadKey();
        }
    }
}
