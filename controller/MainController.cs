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
                            int layoutTheme = int.Parse(menu.AskUser("Choose 1 - compact | Choose 2 - verbose"));
                            if (layoutTheme == 1) {
                                foreach (Member members in database.GetAllMembers()) {
                                    menu.ShowInformation(members.CompactTheme());
                                }

                            } else if (layoutTheme == 2) {
                                foreach (Member members in database.GetAllMembers()) {
                                    menu.ShowInformation(members.VerboseTheme());
                                }
                            }

                                int userChoosesMember = int.Parse(menu.AskUser(this.menu.AskUser("Select member by ID")));
                                Member memberFromDb = database.GetMember(userChoosesMember);


                            break;
                        case 2:
                            string name = menu.AskUser("Name: ____");
                            string personalNumber = menu.AskUser("PersonalNumber: ____");
                            long memberID = database.GenerateID();
                            Member member = new Member(name, personalNumber, memberID);
                            database.AddMember(member);
                            break;
                        case 3:
                            WriteLine("Bye bye!\n");
                        break;
                    }
                }

                catch (Exception Ex)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("----------------------------------------");
                    WriteLine(Ex.Message);
                    WriteLine("----------------------------------------");
                    ResetColor();
                }
            }
            return false;
        }
    }
}