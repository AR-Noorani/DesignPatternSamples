using System;

namespace Mediator
{
    class Program
    {
        static void Main()
        {
            var director = new FontDialogDirector(new[] { "Arial", "Tahoma", "Another" });

            #region User Interactions
            
            director.FontListClick();
            director.FontListClick();

            director.OkClick();

            director.CancelClick();

            #endregion

            Console.ReadKey();
        }
    }
}
