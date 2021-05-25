using System;

namespace Command
{
    class Program
    {
        static void Main()
        {
            ServiceLocator.Register<CalculatorCore>();

            var calculator = new Calculator();
            Console.WriteLine(calculator.Value);

            calculator.ExecuteCommand<PutCommand>(10);
            Console.WriteLine(calculator.Value);

            calculator.ExecuteCommand<AddCommand>(2);
            Console.WriteLine(calculator.Value);

            calculator.ExecuteCommand<SubCommand>(4);
            Console.WriteLine(calculator.Value);

            calculator.ExecuteCommand<MulCommand>(3);
            Console.WriteLine(calculator.Value);

            calculator.ExecuteCommand<DivCommand>(8);
            Console.WriteLine(calculator.Value);

            Console.WriteLine();

            calculator.Undo();
            Console.WriteLine(calculator.Value);
            calculator.Undo();
            Console.WriteLine(calculator.Value);
            calculator.Undo();
            Console.WriteLine(calculator.Value);
            calculator.Undo();
            Console.WriteLine(calculator.Value);
            calculator.Undo();
            Console.WriteLine(calculator.Value);

            Console.ReadKey();
        }
    }
}
