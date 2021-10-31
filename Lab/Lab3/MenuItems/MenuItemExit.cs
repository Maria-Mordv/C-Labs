using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.MenuItems
{
    public class MenuItemExit : MenuItemCore
    {
        public override string Title { get { return "Exit"; } }

        public override void Execute()
        {
            Console.WriteLine("\nExit...");
            Environment.Exit(0);
        }
    }
}
