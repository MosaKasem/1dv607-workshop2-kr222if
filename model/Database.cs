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
            if (!File.Exists(jsonFile)) {
                CreateDataBaseModel();
            }
            string json;
            using (var reader = new StreamReader(jsonFile))
            {
                json = reader.ReadToEnd();
            }
            WriteLine(json);
            _members = JsonConvert.DeserializeObject<List<Member>>(json);
        }
        public void CreateDataBaseModel()
        {
            var dummy = new Member("Jimmy", "25", 33);
            dummy.RegisterBoat(new Boat(BoatTypes.Kayak, 25));
            _members.Add(dummy);
            using (StreamWriter createFile = File.CreateText(jsonFile))
            {
                createFile.WriteLine(JsonConvert.SerializeObject(_members));
            }
        }
        public void AddMember(Member member)
        {
            _members.Add(member);
            // SaveToDataBase();
        }
        public List<string> toStringList()
        {
            return _members.Select(_members => _members.ToString()).ToList();
        }
        public void SaveToDataBase()
        {
            var json = JsonConvert.SerializeObject(_members);
            File.WriteAllText(jsonFile, json);
        }
    }
}