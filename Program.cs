using System;
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
            BoatTypes boatType = BoatTypes.SailBoat;

            Boat boat = new Boat(boatType, 25);
            Member member = new Member("Johnny", 25, 40);
            member.RegisterBoat(boat);
            
            // try {
                WriteLine(boat.BoatType);
                // WriteLine(member.Boats);

            // } catch (Exception Ex) {
                // WriteLine(Ex.Message);
            // }
        }
    }
}
