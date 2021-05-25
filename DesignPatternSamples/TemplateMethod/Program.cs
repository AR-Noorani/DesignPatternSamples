using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main()
        {
            Pizza pizza = new MeatPizza();
            pizza.Prepare();

            pizza = new CheesePizza();
            pizza.Prepare();

            Console.ReadKey();
        }
    }
}
