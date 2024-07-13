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
            //creates and add the subMenu  
            MenuItem dateOrTimeSubMenu = interfaceMenu.AddANewMenuItemToMainMenu (dateSubMenuItem);
            //creates and add the actions of show time and date into dateOrTime subMenu
            ShowCurrentDate currentDate = new ShowCurrentDate(dateOrTimeSubMenu);
            ShowCurrentTime currentTime = new ShowCurrentTime(dateOrTimeSubMenu);
            //creates and add the subMenu  
            MenuItem versionAndCapitalsSubMenu = interfaceMenu.AddANewMenuItemToMainMenu(varsionAndCapitalSubMenuItem);
            //creates and add the actions of show version and count capitals letter into versionAndCapitals subMenu
            ShowVersion version = new ShowVersion(versionAndCapitalsSubMenu);
            CountCapitals countCapitals = new CountCapitals(versionAndCapitalsSubMenu);

            return interfaceMenu;
        }
    }
}
