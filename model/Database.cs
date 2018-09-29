using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using static System.Console;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace _1dv607_workshop2_kr222if
{
    public class Database
    {
        private string jsonFile = "database.json";
        private string database;
        public List<Member> Members { get; set; }
        public Database()
        {
            Members = new List<Member>();
        }

        public void ReadJsonFile()
        {
            database = File.ReadAllText(jsonFile);
            WriteLine(database.GetType());

            WriteLine(database);
        }
        public void saveData()
        {
            /* Database db = JsonConvert.DeserializeObject<Database>(database);
            WriteLine(db); */

        }
    }
}