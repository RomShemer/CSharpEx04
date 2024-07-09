using B24_Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem
    {
        private readonly string r_Title;
        private readonly MenuItem r_Parent; //todo
        private List<IMenuItemListener> m_ItemMenuListenersList = new List<IMenuItemListener>();
        private List<MenuItem> m_ItemsList = new List<MenuItem>();


        public MenuItem(string i_Title, MenuItem i_Parent)
        {
            r_Title = i_Title;
            r_Parent = i_Parent;
        }

        public string Title
        {
            get
            {
                return r_Title;
            }
        }

        public int NumberOfItems
        {
            get
            {
                return m_ItemsList.Count;
            }
        }

        public void AddItemMenuListener(IMenuItemListener i_MenuItemListener)
        {
            m_ItemMenuListenersList.Add(i_MenuItemListener);
        }

        public MenuItem AddSubMenuItem(string i_Title)
        {
            MenuItem subMenuItem = new MenuItem(i_Title, this);
            m_ItemsList.Add(subMenuItem);

            return subMenuItem;
        }

        public void RemoveItemSelectedListener(IMenuItemListener i_MenuItemListener)
        {
            m_ItemMenuListenersList.Remove(i_MenuItemListener);
        }

        public void NotifyMenuItemSelectedListeners()
        {
            foreach (IMenuItemListener listener in m_ItemMenuListenersList)
            {
                listener.ReportSelectedActionToListenerFromMenu();
            }
        }

        public void ActivateItem(int i_ItemIndexToActivate)
        {
            if (m_ItemsList[i_ItemIndexToActivate].NumberOfItems > 1)
            {
                activateSubMenuItem(m_ItemsList[i_ItemIndexToActivate]);

            }
            else
            {
                m_ItemsList[i_ItemIndexToActivate].Selected();
            }
        }
        private void activateSubMenuItem(MenuItem i_SubMenuItem)
        {
            //bulidMenuFormat();

            while(true)
            {
                Console.Clear();
                Console.WriteLine(i_SubMenuItem.Title);

                //PrintFunction OfMenuItem
                Console.WriteLine("0. Back"); //console?

                //just for debug
                i_SubMenuItem.ShowMenuItems();
                int choice = UserChoice.UserChoiceMethods.GetValidUserChoice(i_SubMenuItem.NumberOfItems);
                if(choice == 0) //change
                {
                    break;
                }

                i_SubMenuItem.ActivateItem(choice - 1);
            }
           

            //print massage
            //getinput from user (limit operssnds)
            // if input == 0
            // if perrsnt == null exit godbay
            //else parent.activate

        }

        private StringBuilder bulidMenuFormat()
        {
            int i = 1;
            StringBuilder menuFormat = new StringBuilder();
            menuFormat.AppendFormat($"{0}:", this.Title);
            menuFormat.AppendLine();
            menuFormat.AppendFormat($"Enter your choise between 0 to {0}", NumberOfItems);
            menuFormat.AppendLine();
            foreach (MenuItem item in m_ItemsList)
            {
                menuFormat.AppendFormat($"{0}. {1}", i, item.Title);
                menuFormat.AppendLine();
                i += 1;
            }
            return menuFormat;
        }

        public void ShowMenuItems() //temp just for debug 
        {
            foreach(MenuItem item in m_ItemsList)
            {
                Console.WriteLine(item.Title);
            }
        }

        //public void ShowSubMenu() //name
        //{
        //    int userChoise;

        //    foreach (MenuItem subMenuItem in m_ItemsList)
        //    {
        //        if (subMenuItem.NumberOfItems > 1) //insert into  bool
        //        {
        //            subMenuItem.ShowSubMenu();
        //        }
        //        else
        //        {
        //            subMenuItem.Selected();
        //        }
        //    }

        //    userChoise = (this as UserChoice.IUserChoiceInterface).GetUserChoice();
        //}

        //int UserChoice.IUserChoiceInterface.GetUserChoice()
        //{
        //    return UserChoice.UserChoiceMethods.GetValidUserChoice(m_ItemsList.Count);
        //}

        public void Selected()
        {
            Console.Clear();
            NotifyMenuItemSelectedListeners();
            Console.WriteLine("Press Enter to continue."); //console?
            Console.ReadLine();
        }
    }
}
