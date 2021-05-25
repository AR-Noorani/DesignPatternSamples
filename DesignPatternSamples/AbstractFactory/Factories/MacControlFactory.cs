namespace AbstractFactory
{
    public class MacControlFactory : IControlFactory
    {
        public TextBox CreateTextBox()
        {
            return new MacTextBox();
        }

        public Button CreateButton()
        {
            return new MacButton();
        }
    }
}
