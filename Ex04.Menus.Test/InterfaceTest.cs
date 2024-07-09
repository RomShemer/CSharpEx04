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
            ShowVersion version = new ShowVersion(versionAndCapitalsSubMenu);
            CountCapitals countCapitals = new CountCapitals(versionAndCapitalsSubMenu);

            return interfaceMenu;
        }
    }
}
