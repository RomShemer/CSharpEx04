using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Delegate;

namespace Ex04.Menus.Test
{
    internal class DelegateTest
    {
        public static MainMenu BuildDelegateMenu()
        {
            string delegateMenuTitle = "Delegate Main Menu";
            string dateSubMenuItem = "Show Date/Time";
            string varsionAndCapitalSubMenuItem = "Version And Capital";
            //are we fine woth this spaces ?
            MainMenu delegateMenu = new MainMenu(delegateMenuTitle);

            MenuItem dateOrTimeMenu = delegateMenu.AddANewMenuItemToMainMenu(dateSubMenuItem);
            MenuItem versionAndCapitalMenu = delegateMenu.AddANewMenuItemToMainMenu(varsionAndCapitalSubMenuItem);

            MenuItem showDate = dateOrTimeMenu.AddMenuItem("Show Date");
            showDate.Selected += menuItemShowDate_Selected;

            MenuItem showTime = dateOrTimeMenu.AddMenuItem("Show Time");
            showTime.Selected += menuItemShowTime_Selected;

            MenuItem countCapitals = versionAndCapitalMenu.AddMenuItem("Count Capitals");
            countCapitals.Selected += menuItemCountCapitals_Selected;

            MenuItem showVersion = versionAndCapitalMenu.AddMenuItem("Show Version");
            showVersion.Selected += menuItemShowVersion_Selected;

            return delegateMenu;
        }

        private static void menuItemShowDate_Selected()
        {
            MenuMethods.ShowCurrentDate();
        }

        private static void menuItemShowTime_Selected()
        {
            MenuMethods.ShowCurrentTime();
        }

        private static void menuItemCountCapitals_Selected()
        {
            MenuMethods.CountCapitals();
        }

        private static void menuItemShowVersion_Selected()
        {
            MenuMethods.ShowVersion();
        }
    }
}
