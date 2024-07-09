using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    internal class InterfacesTest
    {
        public static MainMenu BuildInterfaceMainMenu()
        {
            string interfaceMenuTitle = "Main Menu";
            string dateSubMenuItem = "Show Date/Time";
            string varsionAndCapitalSubMenuItem = "Version And Capital";

            MainMenu interfaceMenu = new MainMenu(interfaceMenuTitle);
            interfaceMenu.AddASubMenuItem (dateSubMenuItem);
            interfaceMenu.AddASubMenuItem(varsionAndCapitalSubMenuItem);

            MenuItem dateOrTimeSubMenu = interfaceMenu.GetMenuItemByTitle(dateSubMenuItem);
            MenuItem versionOrCapitalsSubMenu = interfaceMenu.GetMenuItemByTitle(varsionAndCapitalSubMenuItem);

            return interfaceMenu;
        }

        //להפריד
        public class ShowCurrentDate : IMenuItemListener
        {
            private readonly string k_Title = "Show Date";
            private readonly MenuItem r_MenuItem;

            public ShowCurrentDate(MenuItem i_Parent)
            {
                r_MenuItem = i_Parent.AddSubMenuItem(k_Title);
                r_MenuItem.AddItemMenuListener(this);
            }

            void IMenuItemListener.ReportSelectedActionToListenerFromMenu()
            {
                MenuMethods.ShowCurrentDate();
            }
        }
    }
}
