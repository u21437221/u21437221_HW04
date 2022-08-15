using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21437221_HW04.Models
{
    public abstract class PersonalInfo
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string IDNumber { get; set; }
        public int Age { get; set; }

        public PersonalInfo(string name, string surname, string idNumber, int age)
        {
            Name = name;
            Surname = surname;
            IDNumber = idNumber;
            Age = age;
        }
    }
}