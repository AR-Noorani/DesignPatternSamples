using System;

namespace Strategy
{
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double GetCircumference()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
