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
            BoatTypes boatType      = BoatTypes.SailBoat;
            BoatTypes boatType2     = BoatTypes.Other;
            BoatTypes boatType3     = BoatTypes.Motorsailer;

            Boat boat   = new Boat(boatType, 25);
            Boat boat2  = new Boat(boatType2, 25);
            Boat boat3  = new Boat(boatType3, 25);

            Member member = new Member("Johnny", 25, 40);

            member.RegisterBoat(boat);
            member.RegisterBoat(boat2);
            member.RegisterBoat(boat3);
            
            // try {
                WriteLine(member.BoatToString());
                Database db = new Database();
                db.LoadFile();
                db.saveData();

                // WriteLine(member.Boats);

            // } catch (Exception Ex) {
                // WriteLine(Ex.Message);
            // }
        }
    }
}
