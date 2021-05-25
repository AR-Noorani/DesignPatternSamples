using System;

namespace Flyweight
{
    class Program
    {
        static void Main()
        {
            var pen = PenFactory.GetMediumPen("Red");
            pen.Draw("Content 1");

            pen = PenFactory.GetThickPen("Blue");
            pen.Draw("Content 2");

            pen = PenFactory.GetThinPen("Green");
            pen.Draw("Content 3");

            Console.ReadKey();
        }
    }
}
