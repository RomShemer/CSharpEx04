namespace Ex04.Menus.Interface
{
	public abstract class MenuItem
	{
        private readonly string r_Title;
        private readonly SubMenu r_Parent;
        public const int k_MainMenuIndexKey = -1;

		public MenuItem(string i_Title, SubMenu i_Parent, int i_ItemIndex)
		{
            bool isMainMenu = i_ItemIndex == k_MainMenuIndexKey;

            if (isMainMenu)
            {
                r_Title = i_Title;
            }
            else
            {
                r_Title = i_ItemIndex + ". " + i_Title;
            }

            r_Parent = i_Parent;
        }

        public string Title
        {
            get
            {
                return r_Title;
            }
        }

        public SubMenu Parent
        {
            get
            {
                return r_Parent;
            }
        }
       
        public abstract void ActivateItem();
    }
}