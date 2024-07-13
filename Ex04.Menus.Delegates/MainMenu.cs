namespace Ex04.Menus.Delegate
{
    public class MainMenu
    {
        private readonly SubMenu r_MainMenuItem;

        public SubMenu MainMenuItem
        {
            get
            {
                return r_MainMenuItem;
            }
        }

        public MainMenu(string i_Title)
        {
            r_MainMenuItem = new SubMenu(i_Title, null, MenuItem.k_MainMenuIndexKey);
        }

        public void RunMenu()
        {
            r_MainMenuItem.ActivateItem();
        }
    }
}