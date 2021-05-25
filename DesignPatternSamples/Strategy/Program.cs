using System;
using System.Linq;

namespace Strategy
{
    class Program
    {
        static void Main()
        {
            var comparer = GetComparer("Circumference");
            var shapeList = CreateShapeList(comparer);
            ShowItems(shapeList);
            Console.WriteLine();

            shapeList.Sort();
            ShowItems(shapeList);

            Console.WriteLine();

            comparer = GetComparer("Area");
            shapeList = CreateShapeList(comparer);
            ShowItems(shapeList);
            Console.WriteLine();

            shapeList.Sort();
            ShowItems(shapeList);

            Console.ReadKey();
        }

        private static ShapeList CreateShapeList(ShapeComparer comparer)
        {
            return new ShapeList(comparer)
            {
                new Rectangle { Width = 100, Height = 20 },
                new Circle{ Radius = 30 },
                new Circle{ Radius = 60 },
                new Rectangle{ Width = 10, Height = 6 }
            };
        }

        private static ShapeComparer GetComparer(string comparerType)
        {
            if (comparerType == "Area")
                return new AreaComparer();
            else
                return new CircumferenceComparer();
        }

        private static void ShowItems(ShapeList shapeList)
        {
            foreach (var shape in shapeList)
                Console.WriteLine(shape.ToString());
        }
    }
}
