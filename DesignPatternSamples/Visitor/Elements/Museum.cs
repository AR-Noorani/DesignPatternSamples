using System;

namespace Visitor
{
    public class Museum : TouristAttraction
    {
        public string Name { get; private set; }

        public Museum(string name)
        {
            Name = name;
        }

        public override void Accept(Visitor visitor)
        {
            visitor.VisitMuseum(this);
        }

        public void Visit()
        {
            Console.WriteLine($"Museum({Name}) ===> Visit");
        }
    }
}
