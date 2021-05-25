namespace Mediator
{
    public class Button : Control
    {
        public Button(DialogDirector director) : base(director)
        {
        }

        private void OnClick()
        {
            Changed();
        }

        #region User Interactions
        public void Click()
        {
            OnClick();
        }
        #endregion
    }
}