using Ex04.Menus.Delegate;

namespace Ex04.Menus.Test
{
    public class DelegateTest
    {
        public static MainMenu BuildDelegateMenu()
        {
            MainMenu delegateMenu = new MainMenu("Delegate Main Menu");
            //creates and add the subMenus
            SubMenu dateOrTimeMenu = new SubMenu("Show Date/Time", delegateMenu.MainMenuItem, delegateMenu.MainMenuItem.NumberOfItems + 1);
            delegateMenu.MainMenuItem.AddMenuItem(dateOrTimeMenu);
            SubMenu versionAndCapitalMenu = new SubMenu("Version And Capital",  delegateMenu.MainMenuItem,
                                                                delegateMenu.MainMenuItem.NumberOfItems + 1);
            delegateMenu.MainMenuItem.AddMenuItem(versionAndCapitalMenu);
            //creates and add the action of show date into the subMenu 
            LeafAction showDate = new LeafAction("Show Date", dateOrTimeMenu, dateOrTimeMenu.NumberOfItems + 1);
            dateOrTimeMenu.AddMenuItem(showDate);
            showDate.Selected += DelegateTest.showDate_Selected;
            //creates and add the action of show time into the subMenu 
            LeafAction showTime = new LeafAction("Show Time", dateOrTimeMenu, dateOrTimeMenu.NumberOfItems + 1);
            dateOrTimeMenu.AddMenuItem(showTime);
            showTime.Selected += DelegateTest.showTime_Selected;
            //creates and add the action of show version into the subMenu 
            LeafAction showVersion = new LeafAction("Show Version", versionAndCapitalMenu, versionAndCapitalMenu.NumberOfItems + 1);
            versionAndCapitalMenu.AddMenuItem(showVersion);
            showVersion.Selected += DelegateTest.showVersion_Selected;
            //creates and add the action of count capitals letter into the subMenu 
            LeafAction countCapitals = new LeafAction("Count Capitals", versionAndCapitalMenu, versionAndCapitalMenu.NumberOfItems + 1);
            versionAndCapitalMenu.AddMenuItem(countCapitals);
            countCapitals.Selected += DelegateTest.countCapitals_Selected;

            return delegateMenu;
        }

        private static void showDate_Selected()
        {
            MenuMethods.ShowCurrentDate();
        }

        private static void showTime_Selected()
        {
            MenuMethods.ShowCurrentTime();
        }

        private static void countCapitals_Selected()
        {
            MenuMethods.CountCapitals();
        }

        private static void showVersion_Selected()
        {
            MenuMethods.ShowVersion();
        }
    }
}
