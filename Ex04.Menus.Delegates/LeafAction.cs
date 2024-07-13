using System;

namespace Ex04.Menus.Delegate
{
    public class LeafAction : MenuItem
    {
        public event Action Selected;

        public LeafAction(string i_Title, SubMenu i_Parent, int i_ItemIndex): base(i_Title, i_Parent,i_ItemIndex){}

        protected virtual void OnSelected() 
        {
            Selected?.Invoke();
        }

        public override void ActivateItem()
        {
            Console.Clear();
            OnSelected();
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
            Parent.ActivateItem();
        }
    }
}