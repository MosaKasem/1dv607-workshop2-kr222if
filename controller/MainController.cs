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
                            if (layoutTheme == 1)
                            {
                                foreach (Member members in this.database.GetAllMembers())
                                {
                                    this.menu.ShowInformation(members.CompactTheme());
                                }

                            }
                            else if (layoutTheme == 2)
                            {
                                foreach (Member members in this.database.GetAllMembers())
                                {
                                    this.menu.ShowInformation(members.VerboseTheme());
                                }
                            }

                            int userChoosesMember = int.Parse(this.menu.AskUser("Select member by ID"));
                            Member memberFromDb = this.database.GetMember(userChoosesMember);

                            this.menu.ShowInformation(memberFromDb.CompactTheme());

                            int userChoosesOption = this.menu.MainMenu("Choose 1 - edit | Choose 2 - delete | choose 3 - boats");
                            switch (userChoosesOption)
                            {
                                case 1:
                                    string updateName = menu.AskUser("Name: ____");
                                    string updatedPersonalNum = menu.AskUser("PersonalNumber: ____");
                                    memberFromDb.Name = updateName;
                                    memberFromDb.PersonalNumber = updatedPersonalNum;
                                    this.database.SaveToDataBase();
                                    break;

                                case 2:
                                    string userConfirm = this.menu.AskUser($"Delete User: \n{memberFromDb.CompactTheme()}?\n Confirm: Y (Capital Letter)!"); userConfirm.ToUpper();
                                    if (userConfirm == "Y")
                                    {
                                        database.DeleteMember(userChoosesMember);
                                    }
                                    break;
                                case 3:
                                    int UserChoosesBoat = this.menu.MainMenu("Choose 1 - Edit Boat | Choose 2 - View Boats | Choose 3 - Exit");
                                    while (true)
                                    {
                                        if (userChooses == 1) AddBoatToUser(memberFromDb);
                                        if (userChooses == 2) ViewBoatsList(memberFromDb);
                                        if (userChooses == 3) break;
                                    }
                                    break;
                            }

                            break;
                        case 2:
                            string name = menu.AskUser("Name: ____");
                            string personalNumber = menu.AskUser("PersonalNumber: ____");
                            long memberID = this.database.GenerateID();
                            Member member = new Member(name, personalNumber, memberID);
                            this.database.AddMember(member);
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
        public void AddBoatToUser(Member member)
        {
            throw new MissingMethodException();
        }
        public void ViewBoatsList(Member member)
        {
            if (member.Boats != null) member.BoatToString();
        }
        public void DeleteBoat(Member member)
        {
            throw new MissingMethodException();
        }
    }

}