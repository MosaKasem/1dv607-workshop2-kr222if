using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using static System.Console;

namespace _1dv607_workshop2_kr222if
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database();
            Menu menu = new Menu();
            MainController controller = new MainController();
            WriteLine("Cheeky breeky, welcome to JellyPirate club!");
            try
            {
                while (controller.MainMenu(database, menu));
            }
            catch (Exception Ex)
            {
                WriteLine("Wo wa wee... something's gone wrong!: " + Ex.Message);
            }
        }
    }
}
