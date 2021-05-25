using System;

namespace FactoryMethod
{
    public static class Factory
    {
        public static Shape FactoryMethod(string shapeName)
        {
            return shapeName switch
            {
                "Circle" => new Circle(),
                "Rectangle" => new Rectangle(),
                _ => throw new ArgumentException("shapeName argument is not valid."),
            };
        }
    }
}
