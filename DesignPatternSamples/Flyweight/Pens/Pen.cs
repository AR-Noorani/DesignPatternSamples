namespace Flyweight
{
    public abstract class Pen
    {
        protected string Color;

        public void SetColor(string color)
        {
            Color = color;
        }

        public abstract void Draw(string content);
    }
}
