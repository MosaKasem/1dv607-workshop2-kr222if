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
        public int MainMenu()
        {
            WriteLine("Cheeky breeky, welcome to jellyblyat club!!");
            WriteLine("Choose 1 - view members || Choose 2 - create member || Choose 3 - call trump" );
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
                        throw new Exception();
                }
                catch (System.Exception Ex)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("\nBlyat.. Choose 1, 2 or 3.\n");
                    Console.ResetColor();
                }
                if (result == 1 || result == 2 || result == 3) {
                    return result;
                }
            }
        }
/*         public int RegisterNewUser()
        {

        } */
    }
}