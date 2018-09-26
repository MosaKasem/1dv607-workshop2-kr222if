using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace _1dv607_workshop2_kr222if
{
    public class Member
    {
        //
        public string       _name           ;
        private int         _memberID       ;
        private int         _personalNumber ;
        private List<Boat>  _memberBoats    ;

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
        public List<Boat> Boats { get {return _memberBoats; } set { value = _memberBoats; } }
        

        /// Functionality!
        public void RegisterBoat (Boat boat) 
        {
            Console.WriteLine(boat);
            _memberBoats.Add(boat);
            Console.WriteLine(_memberBoats);
        }
    }
}