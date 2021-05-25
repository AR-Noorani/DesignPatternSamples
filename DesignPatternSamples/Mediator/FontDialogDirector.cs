using System;

namespace Mediator
{
    public class FontDialogDirector : DialogDirector
    {
        private readonly ListBox _fontList;
        private readonly TextBox _fontName;
        private readonly Button _ok;
        private readonly Button _cancel;

        public FontDialogDirector(string[] fonts)
        {
            _fontList = new ListBox(this, fonts);
            _fontName = new TextBox(this);
            _ok = new Button(this);
            _cancel = new Button(this);
        }

        public override void ControlChanged(Control changedcontrol)
        {
            if (changedcontrol == _fontList)
            {
                _fontName.SetText(_fontList.GetSelection());
                Console.WriteLine($"font changes to {_fontName.GetText()}.");
            }
            else if (changedcontrol == _ok)
            {
                // apply font change and dismiss dialog
                Console.WriteLine("font changes applied and the dialog is closed.");
            }
            else if (changedcontrol == _cancel)
            {
                // dismiss dialog
                Console.WriteLine("The dialog is closed.");
            }
        }

        #region User Interactions
        public void FontListClick()
        {
            _fontList.Click();
        }

        public void OkClick()
        {
            _ok.Click();
        }

        public void CancelClick()
        {
            _cancel.Click();
        }
        #endregion
    }
}
