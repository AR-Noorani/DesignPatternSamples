using System.Collections.Generic;

namespace Flyweight
{
    public class PenFactory
    {
        private static readonly Dictionary<string, Pen> pens = new();

        public static Pen GetThickPen(string color)
        {
            return GetPen<ThickPen>(color);
        }

        public static Pen GetThinPen(string color)
        {
            return GetPen<ThinPen>(color);
        }

        public static Pen GetMediumPen(string color)
        {
            return GetPen<MediumPen>(color);
        }

        private static Pen GetPen<T>(string color) where T : Pen, new()
        {
            var key = typeof(T).Name;

            var penExists = pens.TryGetValue(key, out var pen);

            if (!penExists)
            {
                pen = new T();
                pens.Add(key, pen);
            }

            pen.SetColor(color);

            return pen;
        }
    }
}
