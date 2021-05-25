using System;

namespace Flyweight
{
    class ThinPen : Pen
    {
        private readonly BrushSize brushSize = BrushSize.Thin;

        public override void Draw(string content)
        {
            Console.WriteLine($"Drawing '{content}' by brush size : {brushSize} and color : {Color}.");
        }
    }
}
