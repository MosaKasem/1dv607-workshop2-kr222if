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
        private static Random randomer = new Random();
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
            _members = JsonConvert.DeserializeObject<List<Member>>(json);
        }
        public void AddMember(Member member)
        {
            _members.Add(member);
            SaveToDataBase();
        }
        public List<string> toStringList()
        {
            return _members.Select(_members => _members.ToString()).ToList();
        }
        public void SaveToDataBase()
        {
            var json = JsonConvert.SerializeObject(_members, Formatting.Indented);
            File.WriteAllText(jsonFile, json);
        }
        public Member GetMember(int id)
        {
            var idNumber = _members.Find(member => member.MemberID == id);
            return idNumber;
        }
        public void DeleteMember(long id)
        {
            foreach (var member in _members)
            {
                if (member.MemberID == id)
                    _members.Remove(member);
            }
            SaveToDataBase();
        }
        public List<Member> GetAllMembers()
        {
            return _members;
        }
        public long GenerateID()
        {
            return DateTime.Now.Millisecond;
        }
    }
}