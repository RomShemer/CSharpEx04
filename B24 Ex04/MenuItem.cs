using B24_Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interface
{
    public class MenuItem
    {
        private readonly string r_Title;
        private readonly MenuItem r_Parent;
        private List<IMenuItemListener> m_ItemMenuListenersList = new List<IMenuItemListener>();
        private List<MenuItem> m_ItemsList = new List<MenuItem>();
        private const int k_backOrExit = 0;
        public const int k_mainMenu = -1;

        public MenuItem(string i_Title, MenuItem i_Parent, int i_ItemIndex)
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

        public void AddItemMenuListener(IMenuItemListener i_MenuItemListener)
        {
            m_ItemMenuListenersList.Add(i_MenuItemListener);
        }

        public MenuItem AddSubMenuItem(string i_Title)
        {
            MenuItem subMenuItem = new MenuItem(i_Title, this, NumberOfItems + 1);
            m_ItemsList.Add(subMenuItem);

            return subMenuItem;
        }

        public void RemoveItemSelectedListener(IMenuItemListener i_MenuItemListener)
        {
            m_ItemMenuListenersList.Remove(i_MenuItemListener);
        }

        public void NotifyMenuItemSelectedListeners()
        {
            foreach (IMenuItemListener listener in m_ItemMenuListenersList)
            {
                listener.ReportSelectedActionToListenerFromMenu();
            }
        }

        public void ActivateItem()
        {
            if (NumberOfItems > 1)
            {
                activateSubMenuItem();
            }
            else
            {
                Selected();
                r_Parent.ActivateItem();
            }
        }

        private void activateSubMenuItem()
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
                    r_Parent.ActivateItem();
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

        public void Selected() //change name mabey actuvate leaf action or listner choose the name u think is best 
        {
            ConsoleUI.PrintMassage("", true);
            NotifyMenuItemSelectedListeners();
            ConsoleUI.PrintMassage("Press Enter to continue");
            Console.ReadLine();
            r_Parent.ActivateItem();
        }
    }
}
