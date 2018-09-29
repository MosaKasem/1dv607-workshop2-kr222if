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
        private string[] database;
        public List<Member> Members {get;set;}
        public Database()
        {
            json = File.ReadAllText("users.json");
            WriteLine(json);
            Members = JsonConvert.DeserializeObject<List<Member>>(json);
            WriteLine(Members);
            // Members = new List<Member>();
        }

        public void ReadDB()
        {
            var Members = new List<Member>();
            string[] json;
            // string db = @".\users.json";
            using (var reader = new StreamReader(@".\data.json"))
            {

            }
            
/*             Database db;

            string json;
            List<Member> database; */
/*             using (var reader = File.OpenRead(@".\users.json")) 
            {
                json = File.ReadAllText(reader);
            } */
/*             using (var reader = new StreamReader(@".\users.json"))
            {
                json = reader.ReadToEnd();
                var jsonObj = JObject.Parse(json);
                // WriteLine(jsonObj.GetType());
                database = JsonConvert.DeserializeObject<List<Member>>(json);
            } */

            // WriteLine(jsonObj);
                // Database db = JsonConvert.DeserializeObject<Database>(File.ReadAllText(json));
                // WriteLine(db);
            // WriteLine(database);
        }
    }
}