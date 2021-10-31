using Lab3.MenuItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu.ClearItems();
            Menu.AddItem(new MenuItemExit());
            Menu.AddItem(new MenuItemHelloWorld());
            Menu.AddItem(new MenuItemCalc());
            Menu.AddItem(new MenuItemDates());
            Menu.AddItem(new MenuItemStrings());
            while (true)
            {
                Menu.Execute();
            }
        }
    }
}