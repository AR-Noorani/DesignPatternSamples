using System;

namespace Builder
{
    class Program
    {
        static void Main()
        {
            var director = new Director();
            
            var corei5Builder = new Corei5Builder();
            director.SetBuilder(corei5Builder);
            director.Construct();
            Console.WriteLine(corei5Builder.GetProduct());

            var corei7Builder = new Corei7Builder();
            director.SetBuilder(corei7Builder);
            director.Construct();
            Console.WriteLine(corei7Builder.GetProduct());

            Console.ReadKey();
        }
    }
}
