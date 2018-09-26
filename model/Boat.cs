using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace _1dv607_workshop2_kr222if
{
    public class Boat
    {
        private double _lenght; 
        private string _boatType;
        public enum BoatType
        {SailBoat, Motorsailer, Kayak, Other}
        public double Length 
        {
            get { return _lenght; }
            set { if (value <= 0 ) throw new Exception("Boat length cannot be lower than 0");
                         _lenght = value;}
        }
        public BoatType boatType 
        {
            get;
            set;
        }
        public Boat(BoatType boatType, double length)
        {
            this.boatType = boatType;
        }
/*         protected Boat(BoatType boatType, double length)
        {
            this.boatType = boatType;
            this.Length = length;
        } */

    }
}