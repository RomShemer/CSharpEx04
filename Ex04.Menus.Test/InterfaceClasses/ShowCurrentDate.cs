using Ex04.Menus.Interface;

namespace Ex04.Menus.Test
{
    public class ShowCurrentDate : IMenuItemListener
    {
        private const string k_Title = "Show Date";
        private readonly LeafAction r_MenuLeafAction;

        public ShowCurrentDate(SubMenu i_Parent)
        {
            r_MenuLeafAction = new LeafAction(k_Title, i_Parent, i_Parent.NumberOfItems + 1);
            i_Parent.AddMenuItem(r_MenuLeafAction);
            r_MenuLeafAction.AddItemMenuListener(this);
        }

        void IMenuItemListener.ReportSelectedToListenerFromMenu()
        {
            MenuMethods.ShowCurrentDate();
        }
    }
}