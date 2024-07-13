using Ex04.Menus.Interface;

namespace Ex04.Menus.Test
{
    public class ShowCurrentTime : IMenuItemListener
    {
        private const string k_Title = "Show Time";
        private readonly MenuItem r_MenuItem;

        public ShowCurrentTime(MenuItem i_Parent)
        {
            r_MenuItem = i_Parent.AddSubMenuItem(k_Title);
            r_MenuItem.AddItemMenuListener(this);
        }

        void IMenuItemListener.ReportSelectedToListenerFromMenu()
        {
            MenuMethods.ShowCurrentTime();
        }
    }
}
