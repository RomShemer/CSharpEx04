using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegate
{
    public class MainMenu
    {
        private readonly MenuItem r_MenuItem;

        public MainMenu(string i_Title)
        {
            r_MenuItem = new MenuItem(i_Title, null, MenuItem.k_mainMenu);
        }

        public MenuItem AddANewMenuItemToMainMenu(string i_NewMenuItemTitle)
        {
            return r_MenuItem.AddMenuItem(i_NewMenuItemTitle);
        }

        public void Run()
        {
            r_MenuItem.ActivateItem();
        }
    }
}
