using System.Collections.Generic;

namespace Visitor
{
    public class TourPlan
    {
        private readonly List<TouristAttraction> attractions = new();

        public void Add(TouristAttraction attraction)
        {
            attractions.Add(attraction);
        }

        public void Accept(Visitor visitor)
        {
            foreach (var attraction in attractions)
                attraction.Accept(visitor);
        }
    }
}
