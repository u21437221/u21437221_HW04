using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21437221_HW04.Models
{
    public class Treatment: PersonalInfo
    {
        public string TreatmentType { get; set; }

        public Treatment(string name, string surname, string idNumber,int cellNumber, int age, string treatmentType) : base(name, surname, idNumber, cellNumber, age)
        {
            TreatmentType = treatmentType;
        }
    }
}