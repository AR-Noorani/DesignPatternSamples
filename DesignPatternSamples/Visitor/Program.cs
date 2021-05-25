using System;

namespace Visitor
{
    class Program
    {
        static void Main()
        {
            var tourPlan = new TourPlan();

            tourPlan.Add(new Museum("A1"));
            tourPlan.Add(new Museum("A2"));
            tourPlan.Add(new Castle("A3"));
            tourPlan.Add(new NaturalPark("A4"));
            tourPlan.Add(new Castle("A5"));

            var visitor = new Visitor();
            tourPlan.Accept(visitor);

            Console.ReadKey();
        }
    }
}
