using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace _1dv607_workshop2_kr222if
{
    public enum BoatTypes {SailBoat = 0, Motorsailer = 1, Kayak = 2, Other = 3}
    public class Boat
    {
        private double _lenght;       
        public double Length 
        {
            get { return _lenght; }
            set { if (value <= 0 ) throw new Exception("Boat length cannot be lower than 0");
                         _lenght = value;}
        }
        public BoatTypes BoatType { get; set; }
        public int ID { get; set; }
        public Boat(int boatType, double length)
        {
            BoatType   = (BoatTypes)boatType;
            Length     = length;
        }

    }
}