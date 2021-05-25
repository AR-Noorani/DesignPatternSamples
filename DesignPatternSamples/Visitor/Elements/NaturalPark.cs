using System;

namespace Visitor
{
    public class NaturalPark : TouristAttraction
    {
        public string Name { get; private set; }

        public NaturalPark(string name)
        {
            Name = name;
        }

        public override void Accept(Visitor visitor)
        {
            visitor.VisitNaturalPark(this);
        }

        public void Watch()
        {
            Console.WriteLine($"NaturalPark({Name}) ===> Watch");
        }
    }
}
