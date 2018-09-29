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
        private string json = "database.json";
        private string database;
        public List<Member> Members {get;set;}
        public Database()
        {
            Members = new List<Member>();
        }

        public void LoadFile()
        {
            database = File.ReadAllText(json);
            WriteLine(database);
        }
        public void saveData()
        {
            var json = JsonConvert.DeserializeObject(database);
            WriteLine(json.Members);
        }
    }
}