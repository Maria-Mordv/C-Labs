using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.MenuItems
{
    public class MenuItemStrings : MenuItemCore
    {
        public override string Title { get { return "Strings"; } }

        public override void Execute()
        {
            Console.WriteLine("\nEnter 2 strings: \n");
            Strings.Comparrison();
        }
    }
}
