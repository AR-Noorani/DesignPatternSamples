using System;

namespace Flyweight
{
    class MediumPen : Pen
    {
        private readonly BrushSize brushSize = BrushSize.Medium;
        
        public override void Draw(string content)
        {
            Console.WriteLine($"Drawing '{content}' by brush size : {brushSize} and color : {Color}.");
        }
    }
}
