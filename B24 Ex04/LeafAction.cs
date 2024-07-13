using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interface
{
    public class LeafAction : MenuItem
    {
        private readonly List<IMenuItemListener> r_ItemMenuListenersList = new List<IMenuItemListener>();

        public LeafAction(string i_Title, SubMenu i_Parent, int i_ItemIndex) : base(i_Title, i_Parent, i_ItemIndex) {}

        public void AddItemMenuListener(IMenuItemListener i_MenuItemListener)
        {
            r_ItemMenuListenersList.Add(i_MenuItemListener);
        }

        public void RemoveItemSelectedListener(IMenuItemListener i_MenuItemListener)
        {
            r_ItemMenuListenersList.Remove(i_MenuItemListener);
        }

        public void NotifySelectedToMenuItemListeners()
        {
            foreach (IMenuItemListener listener in r_ItemMenuListenersList)
            {
                listener.ReportSelectedToListenerFromMenu();
            }
        }

        public override void ActivateItem()
        {
            ConsoleMenu.PrintMessage("", true);
            NotifySelectedToMenuItemListeners();
            ConsoleMenu.PrintMessage("Press any key to continue");
            Console.ReadLine();
            Parent.ActivateItem();
        }
    }
}