using System;

namespace Interpreter
{
    class Program
    {
        static void Main()
        {
            var b1 = new BoolExpression(true);
            var b2 = new BoolExpression(false);
            var b3 = new BoolExpression(true);

            var b1_or_b2 = new OrExpression(b1, b2);
            Console.WriteLine(b1_or_b2.Interpret());

            var not_b3 = new NotExpression(b3);
            Console.WriteLine(not_b3.Interpret());

            var b1_or_b2_and_not_b3 = new AndExpression(b1_or_b2, not_b3);
            Console.WriteLine(b1_or_b2_and_not_b3.Interpret());

            Console.ReadKey();
        }
    }
}
