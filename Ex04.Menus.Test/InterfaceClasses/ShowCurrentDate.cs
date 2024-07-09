using Ex04.Menus.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class ShowCurrentDate : IMenuItemListener
    {
        private const string k_Title = "Show Date";
        private readonly MenuItem r_MenuItem;

        public ShowCurrentDate(MenuItem i_Parent)
        {
            r_MenuItem = i_Parent.AddSubMenuItem(k_Title);
            r_MenuItem.AddItemMenuListener(this);
        }

        void IMenuItemListener.ReportSelectedActionToListenerFromMenu()
        {
            MenuMethods.ShowCurrentDate();
        }
    }
}
