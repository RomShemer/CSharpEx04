namespace Ex04.Menus.Interface
{
    public class MainMenu
    {
        private readonly MenuItem r_MenuItemHead;
        public MainMenu(string i_Title)
        {
            r_MenuItemHead = new MenuItem(i_Title, null, MenuItem.k_mainMenu);
        }

        public MenuItem AddANewMenuItemToMainMenu(string i_NewMenuItemTitle)
        {
            return r_MenuItemHead.AddSubMenuItem(i_NewMenuItemTitle);
        }

        public void Run()
        {
            r_MenuItemHead.ActivateItem();
        }
    }
}


