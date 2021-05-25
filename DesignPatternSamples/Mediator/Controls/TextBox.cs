namespace Mediator
{
    public class TextBox : Control
    {
        private string _value;

        public TextBox(DialogDirector director) : base(director)
        {
        }

        public void SetText(string value)
        {
            _value = value;
        }

        public string GetText()
        {
            return _value;
        }
    }
}