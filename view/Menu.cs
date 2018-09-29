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
        public int choiceMenu()
        {
            WriteLine("Blyat, welcom to main maneu!!");
            WriteLine("Choose 1, to view our members || Choose 2, to create a member || Choose 3, to call trump" );
            bool choice;
            int result;
            while(true)
            {
                choice = int.TryParse(Console.ReadLine(), out result);
                try
                {
                    if (result != 1 || result != 2 || result != 3)
                        throw new Exception();
                }
                catch (System.Exception Ex)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nBlyat.. Choose 1, 2 or 3.\n");
                    Console.ResetColor();
                }
                // return 1;
            }

        }
    }
}