using System;

namespace TemplateMethod
{
    public class CheesePizza : Pizza
    {
        protected override void AddToppings()
        {
            Console.WriteLine("Adding Cheese Pizza Toppings...");
        }
    }
}
