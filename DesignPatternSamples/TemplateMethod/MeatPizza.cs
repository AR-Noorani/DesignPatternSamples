using System;

namespace TemplateMethod
{
    public class MeatPizza : Pizza
    {
        protected override void AddToppings()
        {
            Console.WriteLine("Adding Meat Pizza Toppings...");
        }
    }
}
