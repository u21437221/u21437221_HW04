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
        public int CellNumber { get; set; }
        public int Age { get; set; }

        public PersonalInfo()
        {

        }
        public PersonalInfo(string name, string surname, string idNumber, int cellNumber, int age)
        {
            Name = name;
            Surname = surname;
            IDNumber = idNumber;
            CellNumber = cellNumber;
            Age = age;
        }
    }
}