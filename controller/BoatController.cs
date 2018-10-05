using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using static System.Console;

namespace _1dv607_workshop2_kr222if
{
    public class BoatController : MainController
    {
        private Menu menu;
        private Database database;
        private Member member;
        public BoatController(Menu menu, Database database, Member member)
        {
            this.menu = menu;
            this.database = database;
            this.member = member;
        }
        public void BoatMenu()
        {
            int UserChoosesBoat = 0;
            do
            {
            UserChoosesBoat = this.menu.MainMenu("Choose 1 - Register Boat | Choose 2 - View Boats | Choose 3 - Exit");
            switch (UserChoosesBoat)
            {
                case 1:
                    int boatType = int.Parse(menu.AskUser("0.SailBoat | 1.Motorsailer | 2.Kayak | 3.Other "));
                    int length = int.Parse(menu.AskUser("Length of the boat?"));

                    Boat boat = new Boat(boatType, length);
                    member.RegisterBoat(boat);

                    this.database.SaveToDataBase();
                    break;

                case 2:
                    this.menu.ShowInformation(BoatToString(member).ToString());
                    int userPicksBoat = int.Parse(this.menu.AskUser("Select boat by ID"));
                    
                    Boat pickedBoat = member.GetBoat(userPicksBoat);
                    int userChoosesTo = int.Parse(this.menu.AskUser("Choose 1 - Edit | Choose 2 - Delete | Choose 3 - Exit"));
                    
                    if (userChoosesTo == 1)
                    {
                        int newBoatType = int.Parse(menu.AskUser("0.SailBoat | 1.Motorsailer | 2.Kayak | 3.Other "));
                        
                        double newBoatLength = int.Parse(menu.AskUser("Length of the boat?"));
                        var newBoat = new Boat(newBoatType, newBoatLength);

                        this.member.UpdateBoat(pickedBoat, newBoat);
                        this.database.SaveToDataBase();
                    }
                    if (userChoosesTo == 2)
                    {
                        string userConfirms = this.menu.AskUser($"Delete Boat: \n{BoatContent(pickedBoat)}\n Confirm: Y (Capital Letter)!");
                        if (userConfirms == "Y")
                        {
                            this.member.DeleteBoat(pickedBoat);
                            this.database.SaveToDataBase();
                        }
                    }
                    break;
                    case 3:
                    WriteLine("-------------");
                    WriteLine("Going Back");
                    WriteLine("-------------");
                    break;
            }
            } while (UserChoosesBoat != 3);
            
         }
    }
}