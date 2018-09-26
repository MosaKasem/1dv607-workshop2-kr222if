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
        public string       _name           ;
        private int         _memberID       ;
        private int         _personalNumber ;
        private List<Boat>  _memberBoats    ;

        /* Getters and Setters */
        public string Name
        {
            get { return _name; }
            set { if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException(nameof(value));
                    _name = value; }
        }
        public int MemberID
        {
            get { return _memberID; }
            set { _memberID = value; }
        }

        public int PersonalNumber
        {
            get { return _personalNumber; }
            set { if (value < 0 || value > 1000) throw new ArgumentException("Personal Number must be between 1-1000");
                    _personalNumber = value; }
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
        public Member(string name, int personalNumber, int memberID)
        {
            Name            =              name;
            MemberID        =          memberID;
            PersonalNumber  =    personalNumber;
            Boats           =  new List<Boat>();
        }
        public List<string> toString() 
        {
            return Boats.Select(boat => boat.ToString()).ToList();
        }
    }
}