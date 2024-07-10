using B24_Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ex04.Menus.Interface
{
    public class MainMenu
    {
        private readonly MenuItem r_MainMenuItem;
        public MainMenu(string i_Title)
        {
            r_MainMenuItem = new MenuItem(i_Title, null, MenuItem.k_mainMenu);
        }

        public MenuItem AddANewMenuItemToMainMenu(string i_NewMenuItemTitle)
        {
            return r_MainMenuItem.AddSubMenuItem(i_NewMenuItemTitle);
        }

        public void Run()
        {
            r_MainMenuItem.ActivateItem();
        }
    }
}


