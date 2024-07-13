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

            MainMenu delegateMenu = new MainMenu(delegateMenuTitle);
            //creates and add the subMenus
            MenuItem dateOrTimeMenu = delegateMenu.AddANewMenuItemToMainMenu(dateSubMenuItem);
            MenuItem versionAndCapitalMenu = delegateMenu.AddANewMenuItemToMainMenu(varsionAndCapitalSubMenuItem);
            //creates and add the action of show date in the subMenu 
            MenuItem showDate = dateOrTimeMenu.AddMenuItem("Show Date");
            showDate.Selected += menuItemShowDate_Selected;
            //creates and add the action of show time in the subMenu 
            MenuItem showTime = dateOrTimeMenu.AddMenuItem("Show Time");
            showTime.Selected += menuItemShowTime_Selected;
            //creates and add the action of count capitals letter the subMenu 
            MenuItem countCapitals = versionAndCapitalMenu.AddMenuItem("Count Capitals");
            countCapitals.Selected += menuItemCountCapitals_Selected;
            //creates and add the action of show version in the subMenu 
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
