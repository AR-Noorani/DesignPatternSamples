namespace Adapter.ClassAdapter
{
    public class MyTextArea : TextArea, IControl
    {
        public void Render()
        {
            Draw();
        }
    }
}
