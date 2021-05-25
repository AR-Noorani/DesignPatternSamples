namespace AbstractFactory
{
    public interface IControlFactory
    {
        TextBox CreateTextBox();
        Button CreateButton();
    }
}
