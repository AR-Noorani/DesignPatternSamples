namespace Strategy
{
    public class CircumferenceComparer : ShapeComparer
    {
        public override int Compare(Shape x, Shape y)
        {
            var diff = x.GetCircumference() - y.GetCircumference();

            if (diff < 0)
                return -1;
            else if (diff > 0)
                return 1;
            else
                return 0;
        }
    }
}
