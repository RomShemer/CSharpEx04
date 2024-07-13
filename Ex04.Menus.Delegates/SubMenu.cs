using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegate
{
    public class SubMenu : MenuItem
    {
        private readonly List<MenuItem> r_ItemsList = new List<MenuItem>();
        private const int k_BackOrExit = 0;

        public SubMenu(string i_Title, SubMenu i_Parent, int i_ItemIndex) : base(i_Title, i_Parent, i_ItemIndex) {}

        public int NumberOfItems
        {
            get
            {
                return r_ItemsList.Count;
            }
        }

        public void AddMenuItem(MenuItem i_Item)
        {
            r_ItemsList.Add(i_Item);
        }

        public override void ActivateItem()
        {
            ConsoleMenu.PrintMessage(bulidMenuFormat().ToString(), true);
            int choice;

            while (true)
            {
                try
                {
                    choice = ConsoleMenu.GetChosenOptionFromUser(k_BackOrExit, NumberOfItems);
                    break;
                }
                catch (Exception exception)
                {
                    ConsoleMenu.PrintMessage(exception.Message);
                    continue;
                }
            }

            performActionBasedOnValidatedChoice(choice);
        }

        private void performActionBasedOnValidatedChoice(int i_Choice)
        {
            bool Chosen = i_Choice == k_BackOrExit;
            bool isMainMenu = Parent == null;

            if (Chosen)
            {
                if (isMainMenu)
                {
                    ConsoleMenu.EndProgramMessage();
                }
                else
                {
                    Parent.ActivateItem();
                }
            }
            else
            {
                r_ItemsList[i_Choice - 1].ActivateItem();
            }
        }

        private StringBuilder bulidMenuFormat()
        {
            StringBuilder menuFormat = new StringBuilder();

            menuFormat.AppendFormat($"{Title}:");
            menuFormat.AppendLine();
            menuFormat.AppendLine("========================");
            menuFormat.AppendFormat($"Enter your choice between 0 to {NumberOfItems}");
            menuFormat.AppendLine();
            foreach (MenuItem item in r_ItemsList)
            {
                menuFormat.AppendFormat($"{item.Title}");
                menuFormat.AppendLine();
            }

            bool isMainMenu = Parent == null;

            if (isMainMenu)
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