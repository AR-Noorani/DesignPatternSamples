namespace Strategy
{
    public abstract class Shape
    {
        public abstract double GetArea();
        public abstract double GetCircumference();

        public override string ToString()
        {
            return $"Area={GetArea()}; Circumference={GetCircumference()}";
        }
    }
}
