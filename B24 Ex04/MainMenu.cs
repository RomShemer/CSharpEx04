using B24_Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private readonly MenuItem r_MenuItem;
        //private const int k_InvalidChoice = -1;
        private List<MenuItem> m_MenuItemsList = new List<MenuItem>();

        public MainMenu(string i_Title)
        {
            r_MenuItem = new MenuItem(i_Title, null);
        }

        public MenuItem AddASubMenuItemToMainMenu(string i_NewMenuItemTitle)
        {
            return r_MenuItem.AddSubMenuItem(i_NewMenuItemTitle);
        }

        public MenuItem GetMenuItemByTitle(string i_Title) //check if not null?  if null create any message?
        {
            return m_MenuItemsList.Find(menuItem => menuItem.Title == i_Title);
        }

        public void Show() //string builder? print in Console?
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Main Menus:");
               
                //PrintFunction OfMenuItem
                Console.WriteLine("0. Exit"); //console?

                //just for debug
                r_MenuItem.ShowMenuItems();
                int coice = UserChoice.UserChoiceMethods.GetValidUserChoice(r_MenuItem.NumberOfItems);
                r_MenuItem.ActivateItem(coice - 1);
            }
        }

    }
}

