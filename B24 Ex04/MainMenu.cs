using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private readonly MenuItem r_MenuItem; //change name
        private List<MenuItem> m_MenuItemsList = new List<MenuItem>();

        public MainMenu(string i_Title)
        {
            r_MenuItem = new MenuItem(i_Title, null, MenuItem.k_mainMenu);
        }

        public void AddASubMenuItem(string i_NewMenuItemTitle)
        {
            r_MenuItem.AddSubMenuItem(i_NewMenuItemTitle);
        }

        public MenuItem GetMenuItemByTitle(string i_Title) //check if not null?  if null create any message?
        {
            return m_MenuItemsList.Find(menuItem => menuItem.Title == i_Title);
        }

        public void Run()
        {
            r_MenuItem.ActivateItem();
        }

        //public void Show() //string builder? print in Console?
        //{
        //    while (true)
        //    {
        //        Console.Clear();
        //        Console.WriteLine("Main Menus:");
               

        //        Console.WriteLine("0. Exit"); //console?

        //        //int choice = GetUserChoice();

        //        if (choice == 0)
        //        {
        //            break;
        //        }
        //        if (choice > 0 && choice <= m_MenuItemsList.Count) //   או לפונקציה להכניס לבוליאני
        //        {
        //            m_MenuItemsList[choice - 1].Selected();
        //        }
        //    }
        //}

        //private int GetUserChoice()
        //{
        //    int choice = k_InvalidChoice;
        //    bool isValidChoice = false;

        //    while (!isValidChoice)
        //    {
        //        isValidChoice = int.TryParse(Console.ReadLine(), out choice); //function for valid input
        //        if (!isValidChoice)
        //        {
        //            Console.WriteLine("Invalid choice, please try again."); //console?
        //        }
        //    }

        //    return choice;
        //}
    }
}

