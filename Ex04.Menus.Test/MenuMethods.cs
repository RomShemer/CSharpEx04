using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class MenuMethods
    {

        public static void ShowVersion()
        {
            Console.WriteLine("App Version: 24.2.4.9504");
            Console.ReadKey();
        }

        public static void CountCapitals()
        {
            Console.WriteLine("Please enter a sentence:");
            string sentence = Console.ReadLine();
            int capitalCount = 0;

            foreach (char c in sentence)
            {
                if (char.IsUpper(c))
                    capitalCount++;
            }
            Console.WriteLine($"There are {capitalCount} capital letters.");
            Console.ReadKey();
        }

        public static void ShowCurrentTime()
        {
            Console.WriteLine($"Current Time: {DateTime.Now.ToString("HH:mm:ss")}");
            Console.ReadKey();
        }

        public static void ShowCurrentDate()
        {
            Console.WriteLine($"Current Date: {DateTime.Now.ToString("dd.MM.yyyy")}");
            Console.ReadKey();
        }
    }
}
