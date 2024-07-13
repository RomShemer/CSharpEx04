namespace Ex04.Menus.Test
{
    public class Program
    {
        static void Main()
        {
            Interface.MainMenu interfaceMenu = InterfaceTest.BuildInterfaceMainMenu();
            interfaceMenu.RunMenu();
            Delegate.MainMenu delegateMenu = DelegateTest.BuildDelegateMenu();
            delegateMenu.RunMenu();
        }
    }
}