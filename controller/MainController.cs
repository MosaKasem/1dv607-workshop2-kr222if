using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using static System.Console;

namespace _1dv607_workshop2_kr222if
{
    public class MainController
    {
        private Database database;
        private Menu menu;
        public bool MainMenu(Database database, Menu menu)
        {
            this.database = database;
            this.menu = menu;

            int userChooses = this.menu.MainMenu();
            do 
            {
                switch (userChooses)
                {
                    case 1:
                    throw new Exception("not implemented");
                    // break;
                    case 2:
                    // menu.RegisterNewUser();
                    break;
                }
                return true;
            } while (userChooses != 3);
            return false;
        }
    }
}