using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using static System.Console;


namespace _1dv607_workshop2_kr222if
{
    public class Member
    {
        /* --------- */
        /* Variables */
        /* --------- */
        private string       _name          ;
        private long         _memberID       ;
        private string      _personalNumber ;


        /* ------------------- */
        /* Getters and Setters */
        /* ------------------- */

        public int NumberOfBoats {get {return Boats.Count; }}
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public long MemberID
        {
            get { return _memberID; }
            set { _memberID = value; }
        }

        public string PersonalNumber
        {
            get { return _personalNumber; }
            set { _personalNumber = value; }
        }
        public List<Boat> Boats { get; set; }
        
        
        /* -------------- */
        /* Functionality! */
        /* -------------- */

        /// <summary>
        /// Constructor, creates a member
        /// </summary>
        /// <param name="name"></param>
        /// <param name="personalNumber"></param>
        /// <param name="memberID"></param>
        public Member(string name, string personalNumber, long memberID)
        {
            this.Name            =              name;
            this.MemberID        =          memberID;
            this.PersonalNumber  =    personalNumber;
            this.Boats           =  new List<Boat>();
        }
        /// <summary>
        /// Registers a boat to a member
        /// </summary>ö
        /// <param name="boat"></param>
        public void RegisterBoat (Boat boat) 
        {
            int maxValue = 0;
            foreach (var id in Boats)
            {
                if (maxValue <= id.ID)
                {
                    maxValue = id.ID;
                }
            }
            boat.ID = ++maxValue;
            Boats.Add(boat);
        }
        public void DeleteBoat (Boat boat) {
            Boats.Remove(boat);
        }
        public void UpdateBoat (Boat oB, Boat nB) {
            oB.BoatType =  nB.BoatType  ;
            oB.Length   =  nB.Length    ;
        }
        public Boat GetBoat(int id)
        {
            Boat boat = Boats.Find(s => s.ID == id);
            if (boat == null) 
            {
                throw new KeyNotFoundException($"Could not find boat with ID: {id}");
            }
            return boat;
        }
    }
}