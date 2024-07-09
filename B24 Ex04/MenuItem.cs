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
        private List<MenuItem> m_subMenuItemList = new List<MenuItem>();


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

        public int NumberOfSubMenuItem
        {
            get
            {
                return m_subMenuItemList.Count;
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

        public void Show()
        {
            int userChoise;

            foreach (MenuItem subMenuItem in m_subMenuItemList)
            {
                userChoise = (this as IUserChoice).GetUserChoice();

                if (subMenuItem.NumberOfSubMenuItem > 1)
                {
                    subMenuItem.Show();
                }
                else
                {
                    subMenuItem.Selected();
                }
            }

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
