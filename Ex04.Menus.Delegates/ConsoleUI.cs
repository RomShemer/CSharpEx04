using System;
using System.Text;

namespace Ex04.Menus.Delegate
{
    public static class ConsoleUI
    {
        public static void PrintMessage(string i_Message, bool i_ToClearScreen = false)
        {
            if (i_ToClearScreen)
            {
                Console.Clear();
            }
            Console.WriteLine(i_Message);
        }

        public static void PrintMessage(StringBuilder i_Message, bool i_ToClearScreen = false)
        {
            if (i_ToClearScreen)
            {
                Console.Clear();
            }
            Console.WriteLine(i_Message);
        }

        public static int GetChosenOptionFromUser(int i_LowerLimit, int i_HigherLimit)
        {
            string input = Console.ReadLine();
            return validateInput(input, i_LowerLimit, i_HigherLimit);
        }

        private static int validateInput(string io_Input, int i_LowerLimit, int i_HigherLimit)
        {
            int choise;
            if (!int.TryParse(io_Input, out choise))
            {
                throw new FormatException($"Please enter a intger number");
            }
            else if (choise < i_LowerLimit || choise > i_HigherLimit)
            {
                throw new ArgumentException($"Please enter a intger number between {i_LowerLimit} - {i_HigherLimit}");
            }
            return choise;
        }

        public static void EndProgram()
        {
            Console.Clear();
            PrintMessage("Program activity ended. Goodbye", true);

        }

        internal static int GetChosenOptionfromUser(int k_backOrExit, int numberOfItems)
        {
            throw new NotImplementedException();
        }
    }
}
