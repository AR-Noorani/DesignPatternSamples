namespace Strategy
{
    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public override double GetArea()
        {
            return Width * Height;
        }

        public override double GetCircumference()
        {
            return 2 * (Width + Height);
        }
    }
}
