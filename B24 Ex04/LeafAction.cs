using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interface
{
    public class LeafAction : MenuItem
    {
        private List<IMenuItemListener> m_ItemMenuListenersList = new List<IMenuItemListener>();

        public LeafAction(string i_Title, SubMenu i_Parent, int i_ItemIndex): base(i_Title, i_Parent,i_ItemIndex)
        {
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

        public override void ActivateItem()
        {
            ConsoleUI.PrintMassage("", true);
            NotifyMenuItemSelectedListeners();
            ConsoleUI.PrintMassage("Press any key to continue");
            Console.ReadLine();
            Parent.ActivateItem();
        }
    }
}

