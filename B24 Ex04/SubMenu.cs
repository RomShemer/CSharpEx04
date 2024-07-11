using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interface
{ 
    public class SubMenu:MenuItem
    {
        private readonly string r_Title;
        private readonly SubMenu r_Parent;
        private List<MenuItem> m_ItemsList = new List<MenuItem>();
        private const int k_backOrExit = 0;
        public const int k_mainMenu = -1;

        public SubMenu(string i_Title, SubMenu i_Parent, int i_ItemIndex)
        {
            if (i_ItemIndex == k_mainMenu)
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

        public int NumberOfItems
        {
            get
            {
                return m_ItemsList.Count;
            }
        }

        public void AddMenuItem(MenuItem i_Item)
        {
            m_ItemsList.Add(i_Item);
        }

        void MenuItem.ActivateItem()
        {
            ConsoleUI.PrintMassage(bulidMenuFormat(), true);
            int choise;
            while (true)
            {
                try
                {
                    choise = ConsoleUI.GetChosenOptionfromUser(k_backOrExit, NumberOfItems);
                }
                catch
                {
                    continue;
                }
                break;
            }

            if (choise == k_backOrExit)
            {
                if (r_Parent == null)
                {
                    ConsoleUI.EndProgram();
                }
                else
                {
                    (r_Parent as MenuItem).ActivateItem();
                }
            }
            else
            {
                m_ItemsList[choise - 1].ActivateItem();
            }
        }

        private StringBuilder bulidMenuFormat()
        {
            StringBuilder menuFormat = new StringBuilder();

            menuFormat.AppendFormat($"{this.Title}:");
            menuFormat.AppendLine();
            menuFormat.AppendLine("========================");
            menuFormat.AppendFormat($"Enter your choice between 0 to {NumberOfItems}");
            menuFormat.AppendLine();
            foreach (MenuItem item in m_ItemsList)
            {
                menuFormat.AppendFormat($"{item.getTitle()}");
                menuFormat.AppendLine();
            }

            if (this.r_Parent == null)
            {
                menuFormat.AppendLine("0. Exit");
            }
            else
            {
                menuFormat.AppendLine("0. Back");
            }

            menuFormat.Append("========================");
            return menuFormat;
        }

        string MenuItem.getTitle()
        {
            return Title;
        }

    }
}


