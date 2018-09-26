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
            BoatType boatType;
            boatType = BoatType.SailBoat;
            Boat boat = new Boat(boatType, 25);
            Member member = new Member();
            member.Boats.Add(boat);
            
            try {
                WriteLine(boat.boatType);
                WriteLine(member.Boats);

            } catch (Exception Ex) {
                WriteLine(Ex.Message);
            }
        }
    }
}
