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
        private string json;
        public List<Member> Members {get;set;}
        public Database()
        {
            Members = new List<Member>();
        }
        public void ReadDB()
        {
            Database db;

            string test = @".\users.json";

            string json;
            List<Member> database;
/*             using (var reader = File.OpenRead(@".\users.json")) 
            {
                json = File.ReadAllText(reader);
            } */
            using (var reader = new StreamReader(@".\users.json"))
            {
                json = reader.ReadToEnd();
                var jsonObj = JObject.Parse(json);
                WriteLine(jsonObj.GetType());
                database = JsonConvert.DeserializeObject<List<Member>>(json);
            }
                var testing = JsonConvert.DeserializeObject<Database>(File.ReadAllText(test));
                WriteLine(testing);
            // WriteLine(jsonObj);
                // Database db = JsonConvert.DeserializeObject<Database>(File.ReadAllText(json));
                // WriteLine(db);
            // WriteLine(database);
        }
    }
}