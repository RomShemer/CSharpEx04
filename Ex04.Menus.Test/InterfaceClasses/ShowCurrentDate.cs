using Ex04.Menus.Interface;

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

        void IMenuItemListener.ReportSelectedToListenerFromMenu()
        {
            MenuMethods.ShowCurrentDate();
        }
    }
}
