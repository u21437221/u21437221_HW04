using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21437221_HW04.Models
{
    public class Donation: PersonalInfo
    {
        public int DonateAmount { get; set; }

        public Donation(string name, string surname, string idNumber,int cellNumber, int age, int donateAmount): base(name, surname, idNumber,cellNumber, age)
        {
            DonateAmount = donateAmount;
        }
    }
}