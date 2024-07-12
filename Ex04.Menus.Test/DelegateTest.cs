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
            MainMenu delegateMenu = new MainMenu("Delegate Main Menu");

            SubMenu dateOrTimeMenu = new SubMenu("Show Date/Time", delegateMenu.MainMenuItem, delegateMenu.MainMenuItem.NumberOfItems + 1);
            delegateMenu.MainMenuItem.AddMenuItem(dateOrTimeMenu);
            SubMenu versionAndCapitalMenu = new SubMenu("Version And Capital",  delegateMenu.MainMenuItem, delegateMenu.MainMenuItem.NumberOfItems+1);
            delegateMenu.MainMenuItem.AddMenuItem(versionAndCapitalMenu);

            LeafAction showDate = new LeafAction("Show Date", dateOrTimeMenu, dateOrTimeMenu.NumberOfItems + 1);
            dateOrTimeMenu.AddMenuItem(showDate);
            showDate.Selected += menuItemShowDate_Selected;

            LeafAction showTime = new LeafAction("Show Time", dateOrTimeMenu, dateOrTimeMenu.NumberOfItems + 1);
            dateOrTimeMenu.AddMenuItem(showTime);
            showTime.Selected += menuItemShowDate_Selected;

            LeafAction countCapitals = new LeafAction("Count Capitals", versionAndCapitalMenu, versionAndCapitalMenu.NumberOfItems + 1);
            versionAndCapitalMenu.AddMenuItem(countCapitals);
            countCapitals.Selected += menuItemShowDate_Selected;

            LeafAction showVersion = new LeafAction("Show Version", versionAndCapitalMenu, versionAndCapitalMenu.NumberOfItems + 1);
            versionAndCapitalMenu.AddMenuItem(showVersion);
            showVersion.Selected += menuItemShowDate_Selected;

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
