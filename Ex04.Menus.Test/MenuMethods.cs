using System;
using System.Linq;

namespace Ex04.Menus.Test
{
    public class MenuMethods
    {
        public static void ShowVersion()
        {
            Console.WriteLine("App Version: 24.2.4.9504");
        }

        public static void CountCapitals()
        {
            string sentence = getValidSentence();
            int capitalCount = 0;

            foreach (char currentChar in sentence)
            {
                if (char.IsUpper(currentChar))
                {
                    capitalCount += 1;
                }
            }

            Console.WriteLine($"There are {capitalCount} capital letters");
        }

        private static string getValidSentence()
        {
            bool isValidInput;
            string sentence;
            string invalidInputMessage = string.Empty;

            do
            {
                if (!string.IsNullOrEmpty(invalidInputMessage))
                {
                    Console.WriteLine(invalidInputMessage);
                }

                Console.WriteLine("Please enter a sentence:");
                sentence = Console.ReadLine();
                isValidInput = sentence.Any(char.IsLetter) && !string.IsNullOrWhiteSpace(sentence);
                invalidInputMessage = "Invalid input, try again";
            } while (!isValidInput);

            return sentence;
        }

        public static void ShowCurrentTime()
        {
            Console.WriteLine($"Current Time: {DateTime.Now.ToString("HH:mm:ss")}");
        }

        public static void ShowCurrentDate()
        {
            Console.WriteLine($"Current Date: {DateTime.Now.ToString("dd.MM.yyyy")}");
        }
    }
}