using System;
using System.Collections.Generic;

namespace Mediator
{
    public class ListBox : Control
    {
        private List<string> _items;
        private string _selectedItem;

        public ListBox(DialogDirector director, string[] fonts) : base(director)
        {
            _items = new List<string>(fonts);
        }

        public string GetSelection()
        {
            return _selectedItem;
        }
        
        private void OnClick()
        {
            Changed();
        }

        #region User Interactions
        public void Click()
        {
            SelectAnItemRandomly();
            OnClick();
        }

        private void SelectAnItemRandomly()
        {
            var r = new Random();
            var random = r.Next(1, _items.Count);
            _selectedItem = _items[random];
        }
        #endregion
    }
}