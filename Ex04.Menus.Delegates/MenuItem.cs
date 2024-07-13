using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegate
{
    public class MenuItem
    {
        private readonly string r_Title;
        private readonly MenuItem r_Parent;
        private List<MenuItem> m_ItemsList = new List<MenuItem>(); //readonly?
        public event Action Selected;
        private const int k_backOrExit = 0;
        public const int k_mainMenu = -1;

        public MenuItem(string i_Title, MenuItem i_Parent, int i_ItemIndex)
        {
            bool isItemIsMainMenu = (i_ItemIndex == k_mainMenu);

            if (isItemIsMainMenu)
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

        public MenuItem AddMenuItem(string i_Title)
        {
            MenuItem menuItem = new MenuItem(i_Title, this, NumberOfItems + 1);
            m_ItemsList.Add(menuItem);

            return menuItem;
        }

        public void ActivateItem()
        {
            bool isItemASubMenu = m_ItemsList.Count > 1;

            if (isItemASubMenu)
            {
                activateSubMenuItem();
            }
            else
            {
                menuItemSelected();
                r_Parent.ActivateItem();
            }
        }

        private void activateSubMenuItem()
        {
            ConsoleUI.PrintMassage(bulidMenuFormat(), true);
            int choise = ConsoleUI.GetChosenOptionfromUser(k_backOrExit, NumberOfItems);
            bool isExitOrBackWasChocen = choise == k_backOrExit;

            if (isExitOrBackWasChocen)
            {
                bool isItemIsMainMenu = (r_Parent == null);

                if (isItemIsMainMenu)
                {
                    ConsoleUI.EndProgram();
                }
                else
                {
                    r_Parent.ActivateItem();
                }
            }
            else
            {
                m_ItemsList[choise - 1].ActivateItem();
            }
        }

        protected virtual void OnSelected()
        {
            Selected?.Invoke(); //or check if null if the version is older
        }

        private void menuItemSelected() //name
        {
            Console.Clear();
            OnSelected();
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
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
    }
}
