namespace Visitor
{
    public class Visitor
    {
        public void VisitMuseum(Museum museum)
        {
            museum.Visit();
        }

        public void VisitCastle(Castle castle)
        {
            castle.Explore();
        }

        public void VisitNaturalPark(NaturalPark naturalPark)
        {
            naturalPark.Watch();
        }
    }
}
