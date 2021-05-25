using System;

namespace Visitor
{
    public class Castle : TouristAttraction
    {
        public string Name { get; private set; }

        public Castle(string name)
        {
            Name = name;
        }

        public override void Accept(Visitor visitor)
        {
            visitor.VisitCastle(this);
        }

        public void Explore()
        {
            Console.WriteLine($"Castle({Name}) ===> Explore");
        }
    }
}
