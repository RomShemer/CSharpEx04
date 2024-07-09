using B24_Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem : IUserChoice
    {
        private readonly string r_Title;
        private readonly MenuItem r_Parent; //todo
        private List<IMenuItemListener> m_ItemMenuListenersList = new List<IMenuItemListener>();
        private List<MenuItem> m_ItemList = new List<MenuItem>();


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
                return m_ItemList.Count;
            }
        }

        public void AddItemMenuListener(IMenuItemListener i_MenuItemListener)
        {
            m_ItemMenuListenersList.Add(i_MenuItemListener);
        }

        public MenuItem AddSubMenuItem(string i_Title)
        {
            MenuItem subMenuItem = new MenuItem(i_Title, this);
            m_subMenuItemList.Add(subMenuItem);

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

        //public void ActivateItem()
        //{
        //    int userChoise;

        //    foreach (MenuItem item in m_ItemList)
        //    {
        //        userChoise = (this as IUserChoice).GetUserChoice();

        //        if (item.NumberOfItems > 1)
        //        {
        //            item.activateSubMenuItem();
        //        }
        //        else
        //        {
        //            item.Selected();
        //        }
        //    }
        //}

        public void ActivateItem()
        {
            if (NumberOfItems > 1)
            {
                activateSubMenuItem();
            }
            else
            {
                Selected();
            }
        }

        private void activateSubMenuItem()
        {
            bulidMenuFormat();
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
            menuFormat.AppendFormat($"{0}:",this.Title);
            menuFormat.AppendLine();
            menuFormat.AppendFormat($"Enter your choise between 0 to {0}", NumberOfItems);
            menuFormat.AppendLine();
            foreach (MenuItem item in m_ItemList)
            {
                menuFormat.AppendFormat($"{0}. {1}", i, item.Title);
                menuFormat.AppendLine();
                i += 1;
            }
            return menuFormat;
        }
        
        int IUserChoice.GetUserChoice()
        {
            return UserChoiceMethods.GetValidUserChoice(m_subMenuItemList.Count);
        }

        public void Selected()
        {
            Console.Clear();
            NotifyMenuItemSelectedListeners();
            Console.WriteLine("Press Enter to continue."); //console?
            Console.ReadLine();
        }
    }
}
