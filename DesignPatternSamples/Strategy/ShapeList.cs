using System.Collections.Generic;

namespace Strategy
{
    public class ShapeList : List<Shape>
    {
        private readonly ShapeComparer comparer;

        public ShapeList(ShapeComparer comparer)
        {
            this.comparer = comparer;
        }

        public new void Sort()
        {
            base.Sort((a, b) => comparer.Compare(a, b));
        }
    }
}
