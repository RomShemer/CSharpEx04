using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegate
{
    public class SubMenu : MenuItem
    { 
        private List<MenuItem> m_ItemsList = new List<MenuItem>();
        private const int k_backOrExit = 0;


        public SubMenu(string i_Title, SubMenu i_Parent, int i_ItemIndex) : base(i_Title, i_Parent, i_ItemIndex)
        {
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

        public override void ActivateItem()
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
                if (Parent == null)
                {
                    ConsoleUI.EndProgram();
                }
                else
                {
                    Parent.ActivateItem();
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
                menuFormat.AppendFormat($"{item.Title}");
                menuFormat.AppendLine();
            }

            if (Parent == null)
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

    }
}


