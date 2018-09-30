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

            int userChooses = 0;
            while (userChooses != 3)
            {
                try
                {
                    userChooses = this.menu.MainMenu("Choose 1 - view members || Choose 2 - create member || Choose 3 - exit app\n");
                    switch (userChooses)
                    {
                        case 1:
                            throw new Exception("View members not implemented\n");
                        case 2:
                            string name = menu.Register("Name: ____");
                            string personalNumber = menu.Register("PersonalNumber: ____");
                            long memberID = database.GenerateID();
                            WriteLine(memberID);
                            Member member = new Member(name, personalNumber, memberID);
                            break;
                        case 3:
                            WriteLine("Bye bye!\n");
                        break;
                    }
                }

                catch (Exception Ex)
                {
                    WriteLine(Ex.Message);
                }
            }
            return false;
        }
    }
}