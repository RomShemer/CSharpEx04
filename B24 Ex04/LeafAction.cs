using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interface
{
    public class LeafAction : MenuItem
    {
        private readonly string r_Title;
        private readonly SubMenu r_Parent;
        private List<IMenuItemListener> m_ItemMenuListenersList = new List<IMenuItemListener>();

        string Title
        {
            get
            {
                return r_Title;
            }
        }

        public LeafAction(string i_Title, SubMenu i_Parent, int i_ItemIndex)
        {
            r_Title = i_ItemIndex + ". " + i_Title;
            r_Parent = i_Parent;
        }

        public void AddItemMenuListener(IMenuItemListener i_MenuItemListener)
        {
            m_ItemMenuListenersList.Add(i_MenuItemListener);
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

        void MenuItem.ActivateItem()
        {
            ConsoleUI.PrintMassage("", true);
            NotifyMenuItemSelectedListeners();
            ConsoleUI.PrintMassage("Press any key to continue");
            Console.ReadLine();
            (r_Parent as MenuItem).ActivateItem();
        }

        string MenuItem.getTitle()
        {
            return Title;
        }

    }
}

