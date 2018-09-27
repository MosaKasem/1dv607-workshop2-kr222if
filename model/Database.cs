using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using static System.Console;
using Newtonsoft.Json;


namespace _1dv607_workshop2_kr222if
{
    public class Database
    {
        private string _dbFile = @"C:\Users\Mosa\1dv607\workshop-2-1dv607-MosaKasem-VS\1dv607-workshop2-kr222if\users.json";
        public List<Member> Members {get;set;}
        public Database()
        {
            Members = new List<Member>();
        }
        public void ReadDB()
        {
            Database db = JsonConvert.DeserializeObject<Database>(File.ReadAllText(_dbFile));
            WriteLine(db);
        }
    }
}