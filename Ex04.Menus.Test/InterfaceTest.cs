using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interface;

namespace Ex04.Menus.Test
{
    public class InterfaceTest
    {
        public static MainMenu BuildInterfaceMainMenu()
        {
            string interfaceMenuTitle = "Interface Main Menu";
            string dateSubMenuItem = "Show Date/Time";
            string varsionAndCapitalSubMenuItem = "Version And Capital";

            MainMenu interfaceMenu = new MainMenu(interfaceMenuTitle);
            MenuItem dateOrTimeSubMenu = interfaceMenu.AddANewMenuItemToMainMenu (dateSubMenuItem);
            //add the subMenuItem to dateOrTime menu
            ShowCurrentDate currentDate = new ShowCurrentDate(dateOrTimeSubMenu);
            ShowCurrentTime currentTime = new ShowCurrentTime(dateOrTimeSubMenu);
            //add the subMenuItem to versionAndCountCapitals menu
            MenuItem versionAndCapitalsSubMenu = interfaceMenu.AddANewMenuItemToMainMenu(varsionAndCapitalSubMenuItem);
            ShowVersion version = new ShowVersion(versionAndCapitalsSubMenu);
            CountCapitals countCapitals = new CountCapitals(versionAndCapitalsSubMenu);

            return interfaceMenu;
        }
    }
}
