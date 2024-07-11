using Ex04.Menus.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class ShowCurrentTime : IMenuItemListener
    {
        private const string k_Title = "Show Time";
        private readonly LeafAction r_MenuItem;

        public ShowCurrentTime(SubMenu i_Parent)
        {
            r_MenuItem = new LeafAction(k_Title, i_Parent, i_Parent.NumberOfItems + 1);
            i_Parent.AddMenuItem(r_MenuItem);
            r_MenuItem.AddItemMenuListener(this);
        }

        void IMenuItemListener.ReportSelectedActionToListenerFromMenu()
        {
            MenuMethods.ShowCurrentTime();
        }
    }
}
