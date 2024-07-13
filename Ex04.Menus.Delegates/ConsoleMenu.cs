using System;
using System.Threading;

namespace Ex04.Menus.Delegate
{
    public static class ConsoleMenu
    {
        public static void PrintMessage(string i_Message, bool i_ShouldClearScreen = false)
        {
            if (i_ShouldClearScreen)
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
            int choice;

            if (!int.TryParse(io_Input, out choice))
            {
                throw new FormatException("Invalid type. Please enter an integer");
            }
            else
            {
                bool isInputInRange = choice >= i_LowerLimit && choice <= i_HigherLimit;

                if (!isInputInRange)
                {
                    throw new ArgumentException($"Invalid input. Please enter an integer between {i_LowerLimit} - {i_HigherLimit}");
                }
            }

            return choice;
        }

        public static void EndProgramMessage()
        {
            PrintMessage("Program activity ended. Goodbye", true);
            Thread.Sleep(1000);
        }
    }
}