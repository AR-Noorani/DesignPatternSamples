using System;

namespace Bridge
{
    class Program
    {
        static void Main()
        {
            Input input = new TextBox { Value = "TextBox User Input" };
            input.Print();
            Console.WriteLine();

            input = new TextArea { Value = "TextArea User Input" };
            input.Print();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
