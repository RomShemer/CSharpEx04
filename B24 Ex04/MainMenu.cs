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
        private readonly MenuItem r_MenuItem; //change name
        private List<MenuItem> m_MenuItemsList = new List<MenuItem>();
        public MainMenu(string i_Title)
        {
            r_MenuItem = new MenuItem(i_Title, null, MenuItem.k_mainMenu);
        }

        public MenuItem AddASubMenuItemToMainMenu(string i_NewMenuItemTitle)
        {
            return r_MenuItem.AddSubMenuItem(i_NewMenuItemTitle);
        }

        public MenuItem GetMenuItemByTitle(string i_Title) //check if not null?  if null create any message?
        {
            return m_MenuItemsList.Find(menuItem => menuItem.Title == i_Title);
        }

        public void Run()
        {
            r_MenuItem.ActivateItem();
        }
    }
}


