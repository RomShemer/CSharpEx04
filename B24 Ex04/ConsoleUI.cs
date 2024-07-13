using System;
using System.Text;

namespace B24_Ex04.Menus.Interfaces
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

		public static void PrintMessage(StringBuilder i_Message, bool i_ToClearScreen = false) //שכפול? אולי עדיף לשלוח כם ToString
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

		private static int validateInput(string  io_Input, int i_LowerLimit, int i_HigherLimit)
		{
			int choise;
			bool isValidInput;

			do
			{
				isValidInput = !int.TryParse(io_Input, out choise) || choise < i_LowerLimit || choise > i_HigherLimit;
                StringBuilder errorMessage = new StringBuilder();
                errorMessage.AppendFormat($"Please enter a integer number between {0} - {1}", i_LowerLimit, i_HigherLimit);
				errorMessage.AppendLine();
                PrintMessage(errorMessage);
			}while (!isValidInput);
			
			return choise;
		}
		public static void EndProgram()
		{
			Console.Clear();
            PrintMessage("Program activity ended. Goodbye", true);
		}
	}
}

