using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegate
{
    public static class ConsoleUI
    {
        public static void PrintMassage(string i_Message, bool i_ToClearScreen = false)
        {
            if (i_ToClearScreen)
            {
                Console.Clear();
            }
            Console.WriteLine(i_Message);
        }

        public static void PrintMassage(StringBuilder i_Message, bool i_ToClearScreen = false)
        {
            if (i_ToClearScreen)
            {
                Console.Clear();
            }
            Console.WriteLine(i_Message);
        }

        public static int GetChosenOptionfromUser(int i_LowerLimit, int i_HigherLimit)
        {
            string input = Console.ReadLine();
            return validateInput(input, i_LowerLimit, i_HigherLimit);
        }

        private static int validateInput(string io_Input, int i_LowerLimit, int i_HigherLimit)
        {
            int choise;
            while (!int.TryParse(io_Input, out choise) || choise < i_LowerLimit || choise > i_HigherLimit)
            {
                StringBuilder errorMessage = new StringBuilder();
                errorMessage.AppendFormat($"Please enter a integer number between {0} - {1}", i_LowerLimit, i_HigherLimit);
                errorMessage.AppendLine();
                PrintMassage(errorMessage);
            }
            return choise;
        }
        public static void EndProgram()
        {
            Console.Clear();
            PrintMassage("Program activity ended. Goodbye", true);

        }
    }
}
