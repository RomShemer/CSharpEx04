using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ex04.Menus.Interface
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
            r_MainMenuItem = new SubMenu(i_Title, null, SubMenu.k_mainMenu);
        }

        public void Run()
        {
            r_MainMenuItem.ActivateItem();
        }
    }
}


