using System;

namespace TemplateMethod
{
    public abstract class Pizza
    {
        public void Prepare()
        {
            PrepareDough();
            AddSauce();
            AddToppings();
            Bake();
        }

        private void PrepareDough()
        {
            Console.WriteLine("Preparing Dough...");
        }

        private void AddSauce()
        {
            Console.WriteLine("Adding Sauce...");
        }

        private void Bake()
        {
            Console.WriteLine("Baking...");
        }

        protected abstract void AddToppings();
    }
}
