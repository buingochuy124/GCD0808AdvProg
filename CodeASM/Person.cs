using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeASM
{
    class Person
    {
        public string Id;
        public string Name;
        public DateTime DayOfBirth;
        public string Role;
        public string Description;

        public Person()
        {
            Id = "N/A";
            Name = "N/A";
            DayOfBirth = new DateTime(2021, 10, 26);
            Role = "N/A";
            Description = "N/A";
        }
        public Person(string name)
        {
            Id = "N/A";
            Name = name;
            DayOfBirth = new DateTime(2021, 10, 26);
            Role = "N/A";
            Description = "N/A";
        }
        public Person(string id , string name, DateTime dayOfBirth, string role, string description)
        {
            Id = id;
            Name = name;
            DayOfBirth = dayOfBirth;
            Role = role;
            Description = description;
        }
        public string GetPersionalInfo(Person person)
        {

            string obj = $"------Persional Infomation of {Name}------" + "\n"
                + "Name:  " + Name + "\nDay Of Birth:  " + DayOfBirth + "\nRole:  " + Role
                + "\nDescription:   " + Description + "\n-------------------------------------------";

            return obj;          
        }
        
    }
}
