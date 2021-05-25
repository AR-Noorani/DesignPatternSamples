using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main()
        {
            var factory = GetFactory("Win");
            var textBox = factory.CreateTextBox();
            var button = factory.CreateButton();

            textBox.Validate();
            button.Press();

            factory = GetFactory("Mac");
            textBox = factory.CreateTextBox();
            button = factory.CreateButton();

            textBox.Validate();
            button.Press();

            Console.ReadKey();
        }

        private static IControlFactory GetFactory(string key)
        {
            return key switch
            {
                "Mac" => new MacControlFactory(),
                "Win" => new WinControlFactory(),
                _ => throw new ArgumentException("key argument is not valid."),
            };
        }
    }
}
