using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace _1dv607_workshop2_kr222if
{
    public class Member
    {

        /* Variables */
        private string       _name          ;
        private long         _memberID       ;
        private string      _personalNumber ;
        private List<Boat>  _memberBoats    ;


        public int NumberOfBoats {get {return Boats.Count; }}

        /* Getters and Setters */
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

                        /* Functionality! */

        /// <summary>
        /// 
        /// </summary>ö
        /// <param name="boat"></param>
        public void RegisterBoat (Boat boat) 
        {
            Boats.Add(boat);
        }
        public void DeleteBoat () {
            // TODO: Add Delete Boat functionality
            throw new NotImplementedException();
        }
        public void UpdateBoat () {
            // TODO: Add Delete Boat functionality
            throw new NotImplementedException();
        }
        public Member(string name, string personalNumber, long memberID)
        {
            this.Name            =              name;
            this.MemberID        =          memberID;
            this.PersonalNumber  =    personalNumber;
            this.Boats           =  new List<Boat>();
        }
        public List<string> BoatToString()
        {
            return Boats.Select(boat => boat.ToString()).ToList();
        }
        public string CompactTheme()
        {
            return $"ID number: {this.MemberID}\n Member: {this.Name} \n Boats: {this.NumberOfBoats} ";
        }
    }
}