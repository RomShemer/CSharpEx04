using Ex04.Menus.Interface;

namespace Ex04.Menus.Test
{
    public class InterfaceTest
    {
        public static MainMenu BuildInterfaceMainMenu()
        {
            MainMenu interfaceMenu = new MainMenu("Interface Main Menu");
            //add Items to main menu
            SubMenu dateSubMenu = new SubMenu("Show Date/Time", interfaceMenu.MainMenuItem, interfaceMenu.MainMenuItem.NumberOfItems + 1);
            interfaceMenu.MainMenuItem.AddMenuItem(dateSubMenu);
            SubMenu versionAndCapitalSubMenu = new SubMenu("Version And Capital", interfaceMenu.MainMenuItem, 
                                                                  interfaceMenu.MainMenuItem.NumberOfItems + 1);
            interfaceMenu.MainMenuItem.AddMenuItem(versionAndCapitalSubMenu);
            //add the subMenuItem to dateOrTime menu
            new ShowCurrentDate(dateSubMenu);
            new ShowCurrentTime(dateSubMenu);
            //add the subMenuItem to versionAndCountCapitals menu
            new ShowVersion(versionAndCapitalSubMenu);
            new CountCapitals(versionAndCapitalSubMenu);

            return interfaceMenu;
        }
    }
}