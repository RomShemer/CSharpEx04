using Ex04.Menus.Interface;

namespace Ex04.Menus.Test
{
    public class ShowVersion : IMenuItemListener
    {
        private const string k_Title = "Show Version";
        private readonly LeafAction r_MenuLeafAction;

        public ShowVersion(SubMenu i_Parent)
        {
            r_MenuLeafAction = new LeafAction(k_Title, i_Parent, i_Parent.NumberOfItems + 1);
            i_Parent.AddMenuItem(r_MenuLeafAction);
            r_MenuLeafAction.AddItemMenuListener(this);
        }

        void IMenuItemListener.ReportSelectedToListenerFromMenu()
        {
            MenuMethods.ShowVersion();
        }
    }
}