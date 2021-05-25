namespace AbstractFactory
{
    public class WinControlFactory : IControlFactory
    {
        public TextBox CreateTextBox()
        {
            return new WinTextBox();
        }

        public Button CreateButton()
        {
            return new WinButton();
        }
    }
}
