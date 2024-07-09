using System;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace B24_Ex04
{
	public static class ConsoleUI
	{
		public static void PrintMassage(string i_Message)
		{
			Console.WriteLine(i_Message);
		}

		public static void PrintMassage(StringBuilder i_Message)
		{
			Console.WriteLine(i_Message);
		}

		public static int GetChosenOptionfromUser(int i_LowerLimit, int i_HigherLimit)
		{
			string input = Console.ReadLine();
			return validateInput(input, i_LowerLimit, i_HigherLimit);
		}

		private static int validateInput(string  io_Input, int i_LowerLimit, int i_HigherLimit)
		{
			int choise;
			while(!int.TryParse(io_Input,out choise) || choise<i_LowerLimit || choise>i_HigherLimit)
			{
				StringBuilder errorMessage = new StringBuilder();
                errorMessage.AppendFormat($"Please enter a intger number between {0} - {1}", i_LowerLimit, i_HigherLimit);
				errorMessage.AppendLine();
                PrintMassage(errorMessage);
			}
			return choise;
		}
	}
}

