namespace Adapter.ObjectAdapter
{
    public class MyTextArea : IControl
    {
        private readonly TextArea adaptee = new();

        public void Render()
        {
            adaptee.Draw();
        }
    }
}
