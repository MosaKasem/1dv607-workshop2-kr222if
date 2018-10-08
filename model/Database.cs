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
        /* --------- */
        /* Variables */
        /* --------- */
        private static Random randomer = new Random();
        private string jsonFile = "database.json";
        private string database;
        private List<Member> _members;

        /// <summary>
        /// Constructor for reading the json file
        /// </summary>
        public Database()
        {
            string json;
            using (var reader = new StreamReader(jsonFile))
            {
                json = reader.ReadToEnd();
            }
            _members = JsonConvert.DeserializeObject<List<Member>>(json);
        }

        /* -------------- */
        /* Functionality! */
        /* -------------- */
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
        public Member GetMember(long id)
        {
            Member idNumber = _members.Find(member => member.MemberID == id);
            return idNumber;
        }
        public void DeleteMember(long id)
        {
            _members.Remove(GetMember(id));
            SaveToDataBase();
        }
        public List<Member> GetAllMembers()
        {
            return _members;
        }
        public long GenerateID()
        {
            long maxValue = 0;
            foreach (var member in _members)
            {
                if (member.MemberID >= maxValue) {
                    maxValue = member.MemberID;
                    maxValue += 1;
                }
            }
            return maxValue;
        }
    }
}