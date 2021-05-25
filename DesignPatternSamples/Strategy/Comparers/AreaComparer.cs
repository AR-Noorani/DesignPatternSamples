namespace Strategy
{
    public class AreaComparer : ShapeComparer
    {
        public override int Compare(Shape x, Shape y)
        {
            var diff = x.GetArea() - y.GetArea();
            
            if (diff < 0)
                return -1;
            else if (diff > 0)
                return 1;
            else
                return 0;
        }
    }
}
