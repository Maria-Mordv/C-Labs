using Lab3.MenuItems;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    public class Menu
    {
        private static List<MenuItemCore> MenuItems = new List<MenuItemCore>();

        public static void ClearItems()
        {
            Menu.MenuItems.Clear();
        }

        public static void AddItem(MenuItemCore menuItem)
        {
            Menu.MenuItems.Add(menuItem);
        }

        public static void Execute()
        {
            ShowMenu();
            int iMenu = IOUtils.SafeReadInteger(null) - 1;
            if (iMenu >= 0 && iMenu < Menu.MenuItems.Count)
            {
                Menu.MenuItems.ToArray()[iMenu].Execute();
            }
            else
            {
                Console.WriteLine("\nMenu item not found");
            }
        }

        private static void ShowMenu()
        {
            Console.WriteLine("\n=== MENU ===");

            int iMenuItem = 1;
            foreach (MenuItemCore menuItem in Menu.MenuItems)
            {
                Console.WriteLine("{0}: {1}", iMenuItem++, menuItem.Title);
            }
        }
    }
}
