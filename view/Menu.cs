using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using static System.Console;

namespace _1dv607_workshop2_kr222if
{
    public class Menu
    {
        public int ViewMenu(string message)
        {
            WriteLine(message);
            return ValidateInputChoice();
        }
        public int ValidateInputChoice()
        {
            bool choice;
            int result;
            while(true)
            {
                choice = int.TryParse(Console.ReadLine(), out result);
                try
                {
                    if (result != 1 && result != 2 && result != 3)
                        throw new Exception("\n--------\nTry Again!\n--------");
                }
                catch (Exception Ex)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(Ex.Message);
                    Console.ResetColor();
                }
                if (result == 1 || result == 2 || result == 3) {
                    return result;
                }
            }
        }
        public string AskUser(string question)
        {
            WriteLine(question);
            return ValidateInputData();
        }
        public string ValidateInputData()
        {
            string userSuggests = "";
            while (true)
            {
                userSuggests = ReadLine();
                if (userSuggests != "" || !string.IsNullOrWhiteSpace(userSuggests))
                {
                return userSuggests;
                } else {
                    BackgroundColor = ConsoleColor.Red;
                    ForegroundColor = ConsoleColor.White;
                    WriteLine("\nMust provide something!\n");
                    ResetColor();
                }
            }
        }
        public void ShowInformation(string information)
        {
            WriteLine("------------------------------------------");
            WriteLine(information);
            WriteLine("------------------------------------------");
        }
    }
}