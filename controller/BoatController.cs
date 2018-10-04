using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using static System.Console;

namespace _1dv607_workshop2_kr222if
{
    public class BoatController
    {
        private Menu menu;
        private Database database;
        private Member member;
        MainController maincontroller = new MainController();
        public BoatController(Menu menu, Database database, Member member)
        {
            this.menu = menu;
            this.database = database;
            this.member = member;
        }
        public void BoatMenu()
        {
            int UserChoosesBoat = this.menu.MainMenu("Choose 1 - Register Boat | Choose 2 - View Boats | Choose 3 - Exit");

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
                        this.menu.ShowInformation(maincontroller.BoatToString(member).ToString());
                        int userPicksBoat = int.Parse(this.menu.AskUser("Select boat by ID"));
                        break;
                }



            // int userPicksType = int.Parse(menu.AskUser("0.SailBoat | 1.Motorsailer | 2.Kayak | 3.Other "));
        }
/*         public BoatTypes retrieveBoatType(int type)
        {
            var boatType = new BoatTypes();
            switch (type)
            {
                case 0:
                    boatType = BoatTypes.SailBoat;
                    break;
                case 1:
                    boatType = BoatTypes.Motorsailer;
                    break;
                case 2:
                    boatType = BoatTypes.Kayak;
                    break;
                case 3:
                    boatType = BoatTypes.Other;
                    break;
            }
            return boatType;
        } */
    }
}