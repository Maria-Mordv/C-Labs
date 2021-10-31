using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.MenuItems
{
    public class MenuItemHelloWorld : MenuItemCore
    {
        public override string Title { get { return "Hello world!"; } }

        public override void Execute()
        {
            Console.WriteLine("\nHello World!");
        }
    }
}
