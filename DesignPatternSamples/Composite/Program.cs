using System;
using System.Collections.Generic;

namespace Composite
{
    class Program
    {
        static void Main()
        {
            Control c = new Panel("pnl1")
            {
                Controls = new List<Control>
                {
                    new TextBox("txt1"),
                    new TextBox("txt2"),
                    new Panel("pnl2")
                    {
                        Controls = new List<Control>
                        {
                            new TextBox("txt3"),
                            new Button("btn1"),
                        }
                    },
                    new Button("btn2")
                }
            };
            c.Display(1);

            Console.ReadKey();
        }
    }
}
