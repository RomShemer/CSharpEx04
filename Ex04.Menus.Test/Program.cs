using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interface;


namespace Ex04.Menus.Test
{
    public class Program
    {
        static void Main()
        {
            Interface.MainMenu interfaceMenu = InterfaceTest.BuildInterfaceMainMenu();
            interfaceMenu.Run();
        }
    }
}
