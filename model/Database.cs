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
        public List<Member> _members;
        public Database()
        {
            string json;
            using (var reader = new StreamReader(jsonFile))
            {
                json = reader.ReadToEnd();
            }
            WriteLine(json);
            _members = JsonConvert.DeserializeObject<List<Member>>(json);
        }


    }
}