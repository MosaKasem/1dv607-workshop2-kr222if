using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace _1dv607_workshop2_kr222if
{
    /// <summary>
    /// Available Boat Types, can insert more
    /// </summary>
    public enum BoatTypes {SailBoat = 0, Motorsailer = 1, Kayak = 2, Other = 3}
    public class Boat
    {
        /* --------- */
        /* Variables */
        /* --------- */
        private double _lenght;

        /* ------------------- */
        /* Getters and Setters */
        /* ------------------- */
        public double Length 
        {
            get { return _lenght; }
            set { if (value <= 0 ) throw new Exception("Boat length cannot be lower than 0");
                         _lenght = value;}
        }
        public BoatTypes BoatType { get; set; }
        public int ID { get; set; }

        /// <summary>
        /// Constructor for boat, a type and a length.
        /// </summary>
        /// <param name="boatType"></param>
        /// <param name="length"></param>
        public Boat(int boatType, double length)
        {
            BoatType   = (BoatTypes)boatType;
            Length     = length;
        }

    }
}