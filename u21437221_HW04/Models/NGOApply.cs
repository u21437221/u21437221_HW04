using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21437221_HW04.Models
{
    public class NGOApply: PersonalInfo
    {
        public string JobType { get; set; }

        public NGOApply(string name, string surname, string idNumber, int age, string jobType): base(name,surname,idNumber,age)
        {
            JobType = jobType;
        }
    }
}