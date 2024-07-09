using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B24_Ex04.Menus.Interfaces
{
    public interface IUserChoice
    {
        int GetUserChoice();
    }

    public class UserChoiceMethods
    {
        private const int k_InvalidChoice = -1;

        public static int GetValidUserChoice(int i_NumberOfOptionsForChoice)
        {
            string choiceStringInput;
            int choiceIntegerInput = k_InvalidChoice;
            bool isValidChoice = false;

            while (!isValidChoice)
            {
                Console.WriteLine("Please enter your choiceStringInput");  //להעביר למחלקת קונסול ולשנות מלל 
                choiceStringInput = Console.ReadLine();
                isValidChoice = IsValidUserChoice(i_NumberOfOptionsForChoice, choiceStringInput, out choiceIntegerInput);

                if (!isValidChoice)
                {
                    Console.WriteLine("Invalid choiceStringInput, please try again."); //console?
                }
            }

            return choiceIntegerInput;
        }

        private static bool IsValidUserChoice(int i_NumberOfOptionsForChoice, string i_UserChoiceString,out int io_UserChoiceInteger)
        {
            bool isValidChoiceParse = int.TryParse(i_UserChoiceString, out io_UserChoiceInteger);
            bool isValidChoiceInValidRange = io_UserChoiceInteger >= 0 && io_UserChoiceInteger <= i_NumberOfOptionsForChoice;

            return isValidChoiceParse && isValidChoiceInValidRange;
        }
    }
}
