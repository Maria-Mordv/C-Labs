using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.MenuItems
{
    public class MenuItemDates : MenuItemCore
    {
        public override string Title { get { return "Recursion date"; } }

        public override void Execute()
        {
            Console.WriteLine("\nEnter 4 dates: \n");
            Dates.RecursionDate();
        }
    }
}
