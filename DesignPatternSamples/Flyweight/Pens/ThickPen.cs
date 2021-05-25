using System;

namespace Flyweight
{
    class ThickPen : Pen
    {
        private readonly BrushSize brushSize = BrushSize.Thick;

        public override void Draw(string content)
        {
            Console.WriteLine($"Drawing '{content}' by brush size : {brushSize} and color : {Color}.");
        }
    }
}
