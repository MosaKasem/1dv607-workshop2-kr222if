using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace _1dv607_workshop2_kr222if
{
    public class Member
    {
        private string _name;
        private string _memberID;
        private string _personalNumber;

        public string Name
        {
            get { return _name; }
            set { if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException(nameof(value));
                    _name = value; }
        }
        public Member(string _name, string _memberID, string _personalNumber) {
            
        }
    }
}