using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interface;

namespace Ex04.Menus.Test
{
    internal class InterfaceTest
    {
        public static MainMenu BuildInterfaceMainMenu()
        {
            string interfaceMenuTitle = "Main Menu";
            string dateSubMenuItem = "Show Date/Time";
            string varsionAndCapitalSubMenuItem = "Version And Capital";

            MainMenu interfaceMenu = new MainMenu(interfaceMenuTitle);
            MenuItem dateOrTimeSubMenu = interfaceMenu.AddASubMenuItemToMainMenu (dateSubMenuItem);

            ShowCurrentDate currentDate = new ShowCurrentDate(dateOrTimeSubMenu);
            ShowCurrentTime currentTime = new ShowCurrentTime(dateOrTimeSubMenu);


            MenuItem versionAndCapitalsSubMenu = interfaceMenu.AddASubMenuItemToMainMenu(varsionAndCapitalSubMenuItem);


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

        //להפריד
        public class ShowCurrentTime : IMenuItemListener
        {
            private readonly string k_Title = "Show Time";
            private readonly MenuItem r_MenuItem;

            public ShowCurrentTime(MenuItem i_Parent)
            {
                r_MenuItem = i_Parent.AddSubMenuItem(k_Title);
                r_MenuItem.AddItemMenuListener(this);
            }

            void IMenuItemListener.ReportSelectedActionToListenerFromMenu()
            {
                MenuMethods.ShowCurrentTime();
            }
        }
    }
}
