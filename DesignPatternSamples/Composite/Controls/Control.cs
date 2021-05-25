namespace Composite
{
    public abstract class Control
    {
        protected string name;
        public Control(string name)
        {
            this.name = name;
        }
        public virtual void Add(Control component) { }
        public virtual void Remove(Control component) { }
        public abstract void Display(int depth);
    }
}
